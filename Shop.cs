using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace FormMarket
{

    public class Shop
    {
        public List<Product> products = new List<Product>();
        private string path = "market_goods.txt";
        internal DataTable table = new DataTable();

        public void setPath (string path)
        { this.path = path; }
        public Shop(string path)
        {
            setPath(path);
            fillTableOfProducts(path);
        }

        public Shop()
        {
            fillTableOfProducts(path);
        }

        public List<Product> productsToShop(string path)
        {
            FileManager fileManager = new FileManager();
            string [] lines = fileManager.readStringsFromFile(path);

            // Заполняем массив данными из файла (i = 1 т.к. первая строка в тхт файле это шапка таблицы)
            for (int i = 1; i<lines.Length; i++)
            {
                products.Add(new Product(lines[i]));
            }
            return products;
        }

        public void fillTableOfProducts (string path)
        {
            products = productsToShop(path);

            //устанавливаем значение для заголовков столбцов
            table.Columns.Add("Brand", typeof(string));
            table.Columns.Add("Model", typeof(string));
            table.Columns.Add("Submodel", typeof(string));
            table.Columns.Add("Memory", typeof(int));
            table.Columns.Add("Quantity", typeof(int));
            
            // Заполнение таблицы
            for (int i = 0; i < products.Count; i++)
            {
                table.Rows.Add(products[i].Brand, products[i].Model, products[i].Submodel, products[i].Memory, products[i].Quantity);
            }
            //return table;
        }
        
        public void Print()
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{products[i].Brand,-10}{products[i].Model,-10}{products[i].Submodel,-10}{products[i].Memory,-10}{products[i].Quantity,-10}");

            }
        }

        public void addFilteringProducts(ComboBox comboBoxFilter)
        {
            // Добавляем элементы в ComboBox - значения брендов
            comboBoxFilter.Items.Add("         "); // Добавить опцию для сброса фильтра
            var brands = products.Select(g => g.Brand).Distinct().ToList();
            comboBoxFilter.Items.AddRange(brands.ToArray());
            comboBoxFilter.SelectedIndex = 0; // Установить первый элемент выбранным
        }


        public void addSortingProducts(ComboBox comboBoxSort)
        { 
           // Добавляем элементы в ComboBox
           comboBoxSort.Items.AddRange(new string[]
            {
                "Без сортировки",
                "По количеству памяти (возрастание)",
                "По количеству памяти (убывание)",
                "По имени бренда (возрастание)",
                "По имени бренда (убывание)"
            });
        }

    }
}
