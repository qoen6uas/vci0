namespace abctest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDCK = new System.Windows.Forms.Button();
            this.btnREG = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPHONE = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPW1 = new System.Windows.Forms.TextBox();
            this.tbPW2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbname.Location = new System.Drawing.Point(229, 142);
            this.tbname.Multiline = true;
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(152, 20);
            this.tbname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(227, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(444, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(444, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "비밀번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(447, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "비밀번호 재입력";
            // 
            // btnDCK
            // 
            this.btnDCK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDCK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDCK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDCK.Location = new System.Drawing.Point(613, 142);
            this.btnDCK.Name = "btnDCK";
            this.btnDCK.Size = new System.Drawing.Size(68, 20);
            this.btnDCK.TabIndex = 8;
            this.btnDCK.Text = "중복확인";
            this.btnDCK.UseVisualStyleBackColor = false;
            this.btnDCK.Click += new System.EventHandler(this.btnDCK_Click);
            // 
            // btnREG
            // 
            this.btnREG.BackColor = System.Drawing.Color.SlateBlue;
            this.btnREG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnREG.ForeColor = System.Drawing.Color.White;
            this.btnREG.Location = new System.Drawing.Point(602, 345);
            this.btnREG.Name = "btnREG";
            this.btnREG.Size = new System.Drawing.Size(153, 38);
            this.btnREG.TabIndex = 9;
            this.btnREG.Text = "회원가입";
            this.btnREG.UseVisualStyleBackColor = false;
            this.btnREG.Click += new System.EventHandler(this.btnREG_Click);
            // 
            // btnBACK
            // 
            this.btnBACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBACK.Location = new System.Drawing.Point(10, 372);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(134, 22);
            this.btnBACK.TabIndex = 10;
            this.btnBACK.Text = "Back";
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(227, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "전화번호";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::abctest.Properties.Resources._2931151_close_delete_exit_remove_x_icon;
            this.pictureBox3.Location = new System.Drawing.Point(752, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnBACK);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 418);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::abctest.Properties.Resources.최종_로고_____________removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(227, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "관리자 회원가입";
            // 
            // tbPHONE
            // 
            this.tbPHONE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPHONE.Location = new System.Drawing.Point(229, 210);
            this.tbPHONE.Multiline = true;
            this.tbPHONE.Name = "tbPHONE";
            this.tbPHONE.Size = new System.Drawing.Size(152, 20);
            this.tbPHONE.TabIndex = 16;
            // 
            // tbID
            // 
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbID.Location = new System.Drawing.Point(447, 142);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(152, 20);
            this.tbID.TabIndex = 17;
            // 
            // tbPW1
            // 
            this.tbPW1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPW1.Location = new System.Drawing.Point(447, 210);
            this.tbPW1.Multiline = true;
            this.tbPW1.Name = "tbPW1";
            this.tbPW1.Size = new System.Drawing.Size(152, 20);
            this.tbPW1.TabIndex = 18;
            // 
            // tbPW2
            // 
            this.tbPW2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPW2.Location = new System.Drawing.Point(450, 282);
            this.tbPW2.Multiline = true;
            this.tbPW2.Name = "tbPW2";
            this.tbPW2.Size = new System.Drawing.Size(152, 20);
            this.tbPW2.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 418);
            this.Controls.Add(this.tbPW2);
            this.Controls.Add(this.tbPW1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbPHONE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnREG);
            this.Controls.Add(this.btnDCK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDCK;
        private System.Windows.Forms.Button btnREG;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPHONE;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPW1;
        private System.Windows.Forms.TextBox tbPW2;
    }
}

