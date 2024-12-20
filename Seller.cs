using Market_try;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMarket
{
    internal class Seller: Market_try.User
    {
        private List<Goods> seller_bucket_goods = new List<Goods>();
        public Seller()
        {
            logPas.id = "";
        }
        public void addToBucket(string cellValue)
        {

        }

    }
}
