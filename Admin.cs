using Market_try;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMarket
{
    internal class Admin: Market_try.User
    {
        private List<Goods> admin_bucket_goods = new List<Goods>();
        public Admin ()
        {
            logPas.id = "";
        }
        public void addToBucket(string cellValue)
        {

        }

    }
}
