﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_try
{
    internal class LoginPassword
    {
        internal string access;
        internal string login;
        internal string password;

        public LoginPassword(string lines)
        {
            string[] values = lines.Split('\t');
            this.access = values[0];
            this.login = values[1];
            this.password = values[2];
        }
        public LoginPassword()
        {
            access = "";
        }
    }
}
