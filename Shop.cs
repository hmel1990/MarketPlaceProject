using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Market_try
{

    public class Shop
    {
        public List<Goods> goods = new List<Goods>();
        public void goodsToShop()
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
                goods.Add(new Goods(lines[i]));
            }

        }
        public void Print()
        {
            for (int i = 0; i < goods.Count; i++)
            {
                Console.WriteLine($"{goods[i].Brand,-10}{goods[i].Model,-10}{goods[i].Submodel,-10}{goods[i].Memory,-10}{goods[i].Quantity,-10}");

                //Console.WriteLine(goods[i].Brand + " " + goods[i].Model + " " + goods[i].Submodel + " " + goods[i].Memory + " " + goods[i].Quantity);
                //Console.WriteLine(goods[i]);
            }
        }


    }
}
