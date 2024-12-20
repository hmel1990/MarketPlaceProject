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
        private List<Goods> custumer_bucket_goods = new List<Goods> ();
        public Customer()
        {
            logPas.id = "";
        }

        public void addToBucket (string cellValue)
        {
            File.AppendAllText("market_goods_korzina.txt", cellValue + logPas.id + "\n");
        }

    }
}
