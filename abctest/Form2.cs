using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace abctest
{
    public partial class Form2 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0zEMJT0ibw3Adjj8O6ox9GpUrUZByncftWDyu9Wa",
            BasePath = "https://fir-kangtaehun-default-rtdb.firebaseio.com/"
        };

        List<PRO> Pro = new List<PRO>();
        List<Button> Buttons = new List<Button>();
        List<CheckBox> checkBoxes = new List<CheckBox>();
        List<Label> labels = new List<Label>();
        List<string> names = new List<string>(); 

        user user;

        IFirebaseClient client;
        private string id;
        start s;
        private int have_user;

        private async void delete_user(string id)
        {
            for (int i = 1; i <= Pro.Count; i++)
            {
                if (checkBoxes[i - 1].Checked == true)
                {
                    if (labels[(int)checkBoxes[i - 1].Tag].Text != "")
                    {
                        var pro = new PRO
                        {
                            NAME = "",
                            PHONE = "",
                            BIRTH = "",
                            ADRS = "",
                            GENDER = ""
                        };

                        var pro1 = new PRO1
                        {
                            PNAME = "",
                            PPHONE = ""
                        };

                        FirebaseResponse response = await client.UpdateAsync($"{id}/user{i}", pro);
                        FirebaseResponse response2 = await client.UpdateAsync($"{id}/user{i}/protecter", pro1);
                        have_user -= 1;
                    }
                }
                else { }
            }
            FirebaseResponse response1 = await client.SetAsync($"{id}/HAVE_USER", have_user);
        }
        private void reset()
        {
            Buttons.Clear();
            labels.Clear();
            checkBoxes.Clear();
            names.Clear();
            flowLayoutPanel1.Controls.Clear();
        }

        private void make_table(List<PRO> p)
        {
            int tag = 0;
            if (p != null)
            {
                foreach (PRO userck in p)
                {
                    if (userck.NAME != "")
                    {
                        Graphics g = flowLayoutPanel1.CreateGraphics();
                        Pen pen = new Pen(Color.Red);

                        Panel panel = new Panel();
                        panel.Size = new Size(flowLayoutPanel1.Width - 20, flowLayoutPanel1.Height / 4);
                        panel.BorderStyle = BorderStyle.FixedSingle;

                        Size asize = new Size(flowLayoutPanel1.Width / 10, panel.Height);
                        Size bsize = new Size(flowLayoutPanel1.Width / 5, panel.Height);

                        CheckBox cb = new CheckBox();
                        cb.Tag = tag;
                        checkBoxes.Add(cb);
                        checkBoxes[tag].Location = new Point(panel.Location.X, panel.Location.Y);
                        checkBoxes[tag].CheckedChanged += Cb_CheckedChanged;

                        Label lblname = new Label();
                        lblname.Text = userck.NAME;
                        lblname.Location = new Point(panel.Location.X, panel.Location.Y);
                        lblname.Size = asize;
                        lblname.Font = new Font(Font.FontFamily, 10, FontStyle.Bold);
                        lblname.Text = userck.NAME;
                        lblname.TextAlign = ContentAlignment.MiddleCenter;
                        lblname.Tag = tag;
                        labels.Add(lblname);

                        Label lblgender = new Label();
                        lblgender.Location = new Point(lblname.Location.X + lblname.Width, panel.Location.Y);
                        lblgender.Size = asize;
                        lblgender.Font = new Font(Font.FontFamily, 10, FontStyle.Bold);
                        lblgender.Text = userck.GENDER;
                        lblgender.TextAlign = ContentAlignment.MiddleCenter;

                        Label lblbirth = new Label();
                        lblbirth.Location = new Point(lblgender.Location.X + lblgender.Width, panel.Location.Y);
                        lblbirth.Size = bsize;
                        lblbirth.Font = new Font(Font.FontFamily, 10, FontStyle.Bold);
                        lblbirth.Text = userck.BIRTH;
                        lblbirth.TextAlign = ContentAlignment.MiddleCenter;

                        Label lblphone = new Label();
                        lblphone.Location = new Point(lblbirth.Location.X + lblbirth.Width, panel.Location.Y);
                        lblphone.Size = bsize;
                        lblphone.Font = new Font(Font.FontFamily, 8, FontStyle.Regular);
                        lblphone.Text = userck.PHONE;
                        lblphone.TextAlign = ContentAlignment.MiddleCenter;

                        Label lbladrs = new Label();
                        lbladrs.Location = new Point(lblphone.Location.X + lblphone.Width, panel.Location.Y);
                        lbladrs.Size = bsize;
                        lbladrs.Font = new Font(Font.FontFamily, 8, FontStyle.Regular);
                        lbladrs.Text = userck.ADRS;
                        lbladrs.TextAlign = ContentAlignment.MiddleCenter;

                        Button btn1 = new Button();
                        btn1.Location = new Point(lbladrs.Location.X + lbladrs.Width, panel.Location.Y);
                        btn1.Size = new Size(80, panel.Height);
                        btn1.BackColor = Color.Green;
                        btn1.Text = "이상 없음";
                        btn1.Click += Btn1_Click;
                        Buttons.Add(btn1);

                        panel.Controls.Add(cb);
                        panel.Controls.Add(lblname);
                        panel.Controls.Add(lblgender);
                        panel.Controls.Add(lblbirth);
                        panel.Controls.Add(lblphone);
                        panel.Controls.Add(lbladrs);
                        panel.Controls.Add(btn1);

                        names.Add("");

                        flowLayoutPanel1.Controls.Add(panel);
                        tag++;
                    }
                }
            }
          
        }

        private async void Btn1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int a = Buttons.IndexOf(button);
            
            SetResponse r = await client.SetAsync($"oper/user{a+1}/ck", 0);
            streaming streaming = new streaming();
            streaming.Show();
        }

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ck = sender as CheckBox;
            int tag = (int)ck.Tag;
            if (ck.Checked == true)
            {
                names[tag] = labels[tag].Text;
            }
            else
            {
                names[tag] = "";
            }
        }

        public Form2(string id, start s)
        {
            InitializeComponent();
            this.id = id;
            this.s = s; 
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;

            client = new FirebaseClient(config);
            if (client != null)
                Console.WriteLine("");

            lblHELLO.Text = $"Welcome {id}";
            FirebaseResponse response = await client.GetAsync($"{id}/HAVE_USER");
            if (response != null)
                have_user = response.ResultAs<int>();
            
            int a = have_user;

            for (int i = 1; i <= a; i++)
            {
                FirebaseResponse resp = await client.GetAsync($"{id}/user{i}");
                if (response != null)
                {
                    PRO pro = resp.ResultAs<PRO>();
                    if (pro.NAME == "") 
                        a += 1; 
                    else
                        Pro.Add(pro);
                }
            }

            make_table(Pro);
            if (Pro.Count == 0)
                timer1.Enabled = false;
            else
                timer1.Enabled = true;
        }

        private void btnLOGOUT_Click(object sender, EventArgs e)
        {
            if (this.s != null)
            {
                s.Show();
            }
            else
            {
                start s = new start();
                s.Show();
            }
            this.Close();
        }

        private void btnUUPDATE_Click(object sender, EventArgs e)
        {
            user = new user(id);
            user.FormClosing += User_FormClosing;
            user.Show();
        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            Pro.Clear();
            get_user_info(id);
        }

        private void btnUDELETE_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            var result = MessageBox.Show("정말로 정보를 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                delete_user(id);
                MessageBox.Show("정보가 삭제되었습니다.");
                Pro.Clear();
                get_user_info(id);
                make_table(Pro);
            }
            else
            {
                MessageBox.Show("정보 삭제가 취소되었습니다.");
            }
            timer1.Enabled = true;
        }

        private async void get_user_info(string id)
        {
            FirebaseResponse res = await client.GetAsync($"{id}/HAVE_USER");
            have_user = res.ResultAs<int>();
            int a = have_user;
            for (int i = 1; i <= a; i++)
            {
                FirebaseResponse resp = await client.GetAsync($"{id}/user{i}");
                if (resp != null)
                {
                    PRO pro = resp.ResultAs<PRO>();
                    if (pro.NAME == "") 
                        a += 1; 
                    else
                        Pro.Add(pro);
                }
            }

            reset();
            make_table(Pro);
            if (Pro.Count == 0)
                timer1.Enabled = false;
            else
                timer1.Enabled = true;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= Pro.Count; i++)
            {
                FirebaseResponse res = await client.GetAsync($"{id}/user{i}");
                if (res != null)
                {
                    PRO p = res.ResultAs<PRO>();
                    int ck = p.ck;
                    if (ck == 1)
                    {
                        Buttons[i - 1].Text = "이상 발생";
                        Buttons[i - 1].BackColor = Color.Red;
                    }
                    else
                    {
                        Buttons[i - 1].Text = "이상 없음";
                        Buttons[i - 1].BackColor = Color.Green;
                    }
                }
                else { }
            }
        }
    }
}
