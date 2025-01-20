using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMarket
{
    public class Seller: FormMarket.User
    {
        private string pathToMarketGoods = "E:\\STEP\\C_sharp .Net\\MarketPlace\\MarketplaceProject\\bin\\Debug\\net9.0-windows\\market_goods.txt";
        //private List<Product> sellerBasketGoods = new List<Product>();

        public Seller()
        {
            currentUserLoginPassword.access = "";
        }


        public void deleteGoodsFromShop(int index)
        {
            // Проверяем, существует ли файл
            if (!File.Exists(pathToMarketGoods))
            {
                Console.WriteLine("Файл не найден.");
                return;
            }

            // Читаем все строки из файла
            var lines = File.ReadAllLines(pathToMarketGoods).ToList();

            // Проверяем, корректен ли номер строки
            if (index < 1 || index > lines.Count)
            {
                Console.WriteLine("Номер строки вне диапазона.");
                return;
            }

            // Удаляем строку с указанным номером (индекс на 1 меньше, так как индексация с 0)
            lines.RemoveAt(index);

            // Перезаписываем файл без удалённой строки
            File.WriteAllLines(pathToMarketGoods, lines);

            //Console.WriteLine($"Строка {index} успешно удалена.");
        }
    }
    
}
