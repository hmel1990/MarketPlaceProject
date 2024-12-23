using Market_try;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMarket
{
    internal class Customer : Market_try.User
    {
        private List<Product> custumer_bucket_goods = new List<Product> ();
        public Customer()
        {
            logPas.access = "";
        }
    }
}
