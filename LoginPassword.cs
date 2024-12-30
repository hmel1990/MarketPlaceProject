using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMarket
{
    internal class LoginPassword
    {
        internal string access;
        internal string login;
        internal string password;
        internal string userID;


        public LoginPassword(string lines)
        {
            string[] values = lines.Split('\t');
            this.access = values[0];
            this.login = values[1];
            this.password = values[2];
            this.userID = values[3];
        }
        public LoginPassword()
        {
            access = "";
        }
        public LoginPassword(int x)
        {
            access = "";
            this.userID = Convert.ToString(x);

        }
    }
}
