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
    public partial class user : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0zEMJT0ibw3Adjj8O6ox9GpUrUZByncftWDyu9Wa",
            BasePath = "https://fir-kangtaehun-default-rtdb.firebaseio.com/"
        };


        IFirebaseClient client;
        private string id;
        private string gender;
        private int have_user;

        public user(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private async void btnF_Click(object sender, EventArgs e)
        {
            DateTime dt1 = DTP.Value;

            int a = have_user;

            var pro1 = new PRO
            {
                NAME = tbPNAME.Text,
                PHONE = tbPHONE.Text,
                ADRS = tbADRS.Text,
                GENDER = gender,
                BIRTH = $"{dt1.Year}/{dt1.Month}/{dt1.Day}",
                ck = 0
            };

            for (int i = 0; i <= a; i++)
            {
                FirebaseResponse r = await client.GetAsync($"{id}/user{i+1}");

                PRO p = r.ResultAs<PRO>();

                if (p != null)
                {
                    if (p.NAME == "")
                    {
                        SetResponse r1 = await client.SetAsync($"{id}/user{i+1}", pro1);

                        var p2 = new PRO1
                        {
                            PNAME = tbPNAME.Text,
                            PPHONE = tbPHONE.Text,
                        };

                        SetResponse r2 = await client.SetAsync($"{id}/user{i+1}/protecter", p2);

                        if (r2 != null)
                        {
                            have_user += 1;
                            SetResponse resp3 = await client.SetAsync($"{id}/HAVE_USER", have_user);
                            MessageBox.Show("사용자 등록에 성공");
                            this.Close();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("실패");
                            break;
                        }
                    }
                    else
                        a += 1;

                    if (a == have_user + 1)
                    {
                        SetResponse response1 = await client.SetAsync($"{id}/user{a}", pro1);

                        var pro2 = new PRO1
                        {
                            PNAME = tbPNAME.Text,
                            PPHONE = tbPHONE.Text,
                        };
                        SetResponse response2 = await client.SetAsync($"{id}/user{a}/protecter", pro2);

                        if (response2 != null)
                        {
                            have_user += 1;
                            SetResponse resp3 = await client.SetAsync($"{id}/HAVE_USER", have_user);
                            MessageBox.Show("사용자 등록에 성공");
                            this.Close();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("실패");
                            break;
                        }
                    }
                }
                else
                {
                    SetResponse response1 = await client.SetAsync($"{id}/user{a+1}", pro1);

                    var pro2 = new PRO1
                    {
                        PNAME = tbPNAME.Text,
                        PPHONE = tbPHONE.Text,
                    };
                    SetResponse response2 = await client.SetAsync($"{id}/user{a+1}/protecter", pro2);

                    if (response2 != null)
                    {
                        have_user += 1;
                        SetResponse resp3 = await client.SetAsync($"{id}/HAVE_USER", have_user);
                        MessageBox.Show("사용자 등록에 성공");
                        this.Close();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("실패");
                        break;
                    }
                }
            }            
        }

        private async void user_Load(object sender, EventArgs e)
        {
            client = new FirebaseClient(config);
            if (client != null)
                Console.WriteLine("success");

            FirebaseResponse response = await client.GetAsync($"{id}/HAVE_USER");

            have_user = response.ResultAs<int>();
        }

        private void cbM_CheckedChanged(object sender, EventArgs e)
        {
            if (cbM.Checked == true)
            {
                cbFM.Checked = false;
                gender = "남성";
            }
        }

        private void cbFM_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFM.Checked == true)
            {
                cbM.Checked = false;
                gender = "여성";
            }
        }
    }
}
