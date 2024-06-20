import cv2
from ultralytics import YOLO
import time
import firebase_admin
from firebase_admin import credentials
from firebase_admin import db
import random
from twilio.rest import Client
from flask import Flask, Response, request

# Firebase 서비스 계정 키 파일 경로
cred = credentials.Certificate(r"yourfile.json")
firebase_admin.initialize_app(cred, {
    'databaseURL': 'YOUR URL'
})

model = YOLO('yolov8n.pt')

cap = cv2.VideoCapture(0)

msgck = 0

# Twilio 설정
account_sid = 'account_sid'
auth_token = 'your auth_token'
client = Client(account_sid, auth_token)
app = Flask(__name__)

# 가능한 문자 메시지 목록
messages = [
    "문자메세지 1",
    "문자메세지 2",
    "문자메세지 3"
]

# 타이머 초기값 설정 (15초)
timer_duration = 15
timer = timer_duration

# person 인식
def check_person(results):
    for result in results:
        if result.boxes:
            for box in result.boxes:
                if box.cls == 0:  # Assuming class 0 is "person"
                    return True
    return False

# 문자 메시지를 보내는 함수
def send_message():
    random_message = random.choice(messages)
    message = client.messages.create(
        to="+821042556609",
        from_="12345420443",
        body=random_message
    )
def generate_frames():
    while True:
        success, frame = cap.read()

        if success:
            results = model(frame)
            # person이 감지되면 타이머를 다시 설정하고 데이터베이스의 타이머 값을 1로 설정
            if check_person(results):
                timer = timer_duration
                ref = db.reference("oper/user1/")
                ref.update({"ck": 0})
                msgck = 0  # 데이터베이스의 타이머 값을 0으로 설정

            # person이 감지되지 않고 타이머가 실행 중일 때
            elif timer > 0:
                time.sleep(1)  # 1초 대기
                timer -= 1  # 타이머 1초 감소

            # 타이머가 0인 상태를 유지
            if timer == 0:  # 데이터베이스의 타이머 값을 1으로 설정
                # 한 번만 문자 메시지 발송
                if msgck == 0:
                    send_message()
                    ref = db.reference("oper/user1/")
                    ref.update({"ck": 1})
                    msgck = 1
    # 루프 종료

            annotated_frame = results[0].plot()
            ret, buffer = cv2.imencode('.jpg',  results[0].plot())
            frame = buffer.tobytes()
            cv2.putText(annotated_frame, f"Timer: {timer} seconds", (10, 30), cv2.FONT_HERSHEY_SIMPLEX, 1, (0, 255, 0), 2)
            cv2.imshow("YOLOv8 Inference", annotated_frame)
            yield (b'--frame\r\n'b'Content-Type: image/jpeg\r\n\r\n' + frame + b'\r\n')

            # 남은 시간 표시
        

            if cv2.waitKey(1) & 0xFF == ord("q"):
                break
        else:
            break

@app.route('/')

def index():
    return Response(generate_frames(), mimetype='multipart/x-mixed-replace; boundary=frame')

if __name__ == "__main__":
    app.run(debug=True)

cap.release()
cv2.waitKey(0)
cv2.destroyAllWindows()
