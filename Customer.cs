using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMarket
{
    public class Customer : FormMarket.User
    {
        private string id;
        private List<Product> custumer_bucket_goods = new List<Product> ();
        public Customer()
        {
            logPas.access = "";
        }
        public string idGetter ()
            { return id; }
    }
}
