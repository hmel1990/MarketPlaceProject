using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FormMarket
{

    public class Shop
    {
        public List<Product> products = new List<Product>();
        public void productsToShop()
        {
            // Считываем все строки из файла
            string[] lines = File.ReadAllLines("market_goods.txt");

            // Проверяем, есть ли строки в файле
            if (lines.Length == 0)
            {
                Console.WriteLine("Файл пуст.");
                return;
            }

            // Заполняем массив данными из файла (i = 1 т.к. первая строка в тхт файле это шапка таблицы)
            for (int i = 1; i<lines.Length; i++)
            {
                products.Add(new Product(lines[i]));
            }

        }
        public void Print()
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{products[i].Brand,-10}{products[i].Model,-10}{products[i].Submodel,-10}{products[i].Memory,-10}{products[i].Quantity,-10}");

                //Console.WriteLine(goods[i].Brand + " " + goods[i].Model + " " + goods[i].Submodel + " " + goods[i].Memory + " " + goods[i].Quantity);
                //Console.WriteLine(goods[i]);
            }
        }


    }
}
