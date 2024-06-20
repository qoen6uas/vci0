using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp;

namespace abctest
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0zEMJT0ibw3Adjj8O6ox9GpUrUZByncftWDyu9Wa",
            BasePath = "https://fir-kangtaehun-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        bool dup_id_check;
            
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FirebaseClient(config);
            if (client != null)
                Console.WriteLine("");
            dup_id_check = false;
        }

        private async void Id_dup_check(string id)
        {
            FirebaseResponse resp = await client.GetAsync(id);

            Dup reg = resp.ResultAs<Dup>();

            if (reg == null)
            {
                MessageBox.Show("아이디 중복 아님", "알림");
                dup_id_check = true;
            }
            else
            {
                MessageBox.Show("아이디 중복, 알림");
            }
        }

        private async void Register(string id, string pw, string pw2, string name, string phone)
        {
            if (dup_id_check == false)
            {
                MessageBox.Show("아이디 중복", "알림");
            }

            else if (pw != pw2)
            {
                MessageBox.Show("pw가 다름", "알림");
            }

            else if (id == null || pw == null || pw2 == null || name == null)
            {
                MessageBox.Show("빈칸 있음", "알림");
            }

            else if (dup_id_check == true && pw == pw2)
            {
                var reg = new Register
                {
                    ID = id,
                    PW = pw,
                    NAME = name,
                    PHONE = phone
                };
                SetResponse response = await client.SetAsync(reg.ID, reg);
                SetResponse res = await client.SetAsync($"{reg.ID}/HAVE_USER", 0);

                MessageBox.Show("회원 가입 성공!", "알림");
            }
        }

        private void btnDCK_Click(object sender, EventArgs e)
        {
            Id_dup_check(tbID.Text);
        }

        private void btnREG_Click(object sender, EventArgs e)
        {
            Register(tbID.Text, tbPW1.Text, tbPW2.Text, tbname.Text, tbPHONE.Text);
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
