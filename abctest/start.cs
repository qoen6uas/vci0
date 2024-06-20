using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace abctest
{
    public partial class start : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0zEMJT0ibw3Adjj8O6ox9GpUrUZByncftWDyu9Wa",
            BasePath = "https://fir-kangtaehun-default-rtdb.firebaseio.com/"
        };

        Form1 f1;
        Form2 f2;

        IFirebaseClient client;

        private async void Login(string id, string pw)
        {
            FirebaseResponse resp = await client.GetAsync($"{id}/");

            Login log = resp.ResultAs<Login>();

            if (resp != null)
            {
                if (log.ID == id && log.PW == pw)
                {
                    f2 = new Form2(id, this);
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("아이디를 잘못입력했습니다.");
                }
            }
        }

        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {
            f1 = null;
            f2 = null;

            client = new FirebaseClient(config);
            if (client != null)
                Console.WriteLine("");
        }
        
        private void btnREG_Click(object sender, EventArgs e)
        {
            f1 = new Form1();
            f1.Show();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            Login(tbID.Text, tbPW.Text);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
