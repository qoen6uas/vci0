using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abctest
{
    internal class Dup
    {
        public string id { get; set; }
    }

    internal class Login
    {
        public string ID { get; set; }
        public string PW { get; set; }
    }

    internal class userck
    {
        public string NAME { get; set; }
        public int ck { get; set; }
    }

    internal class PRO
    {
        public string NAME { get; set; }
        public string PHONE { get; set; }
        public string ADRS { get; set; }
        public string GENDER { get; set; }
        public string BIRTH { get; set; }
        public int ck { get; set; }
    }

    internal class PRO1
    {
        public string PNAME { get; set; }
        public string PPHONE { get; set; }
    }

    internal class Register
    {
        public string ID {  get; set; }
        public string PW { get; set; }
        public string NAME { get; set; }
        public string PHONE { get; set; }   
    }

    internal class HAVE_USER
    {
        public int cnt { get; set; }
    }
}
