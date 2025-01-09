using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMarket
{
    public class Seller: FormMarket.User
    {
        //private List<Product> sellerBasketGoods = new List<Product>();

        public Seller()
        {
            currentUserLoginPassword.access = "";
        }


        public void deleteGoodsFromShop(int index)
        {
            // Проверяем, существует ли файл
            if (!File.Exists("market_goods.txt"))
            {
                Console.WriteLine("Файл не найден.");
                return;
            }

            // Читаем все строки из файла
            var lines = File.ReadAllLines("market_goods.txt").ToList();

            // Проверяем, корректен ли номер строки
            if (index < 1 || index > lines.Count)
            {
                Console.WriteLine("Номер строки вне диапазона.");
                return;
            }

            // Удаляем строку с указанным номером (индекс на 1 меньше, так как индексация с 0)
            lines.RemoveAt(index);

            // Перезаписываем файл без удалённой строки
            File.WriteAllLines("market_goods.txt", lines);

            //Console.WriteLine($"Строка {index} успешно удалена.");
        }
    }
    
}
