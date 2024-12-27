using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMarket
{
    internal class Basket
    {
        //internal DataTable tableBasketProducts;
        //private List<Product> productsInBasket;
        internal DataTable tableBasketProducts = new DataTable();


        private string pathToBasket = "market_goods_korzina.txt";
        public Basket()
        {
            addNamesToColumnsBasket(tableBasketProducts);
            fillBasket(tableBasketProducts);
        }
        public void addProductToBasket(User user, Customer customer, DataGridView dataGridView1, string cellValue)
        {             
            // Проверяем, что выбрана строка
            if (dataGridView1.CurrentRow != null)
            {
                // Сохраняем значение первой ячейки выбранной строки
                for (int i = 0; i < (dataGridView1.Columns.Count); i++)
                {
                    cellValue += dataGridView1.CurrentRow.Cells[i].Value?.ToString() + "\t";//!!!!!!! значение и которое потом запишется в тхт файл корзины)
                }                
                cellValue = (user.logPas.userID + "\t" + cellValue);
                MessageBox.Show($"Содержимое первой ячейки строки скопировано: {cellValue}");
                FileManager fm = new FileManager();
                fm.addStringToFile(pathToBasket,cellValue);
                cellValue = "";
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку.");
            }
        }
        public void addNamesToColumnsBasket(DataTable tableBasketProducts)
        {
            //устанавливаем значение для заголовков столбцов
            tableBasketProducts.Columns.Add("Id", typeof(int));
            tableBasketProducts.Columns.Add("Brand", typeof(string));
            tableBasketProducts.Columns.Add("Model", typeof(string));
            tableBasketProducts.Columns.Add("Submodel", typeof(string));
            tableBasketProducts.Columns.Add("Memory", typeof(int));
            tableBasketProducts.Columns.Add("Quantity", typeof(int));
            tableBasketProducts.Columns.Add("Price (USD)", typeof(int));
        }
        public void fillBasket(DataTable tableBasketProducts)
        {

            FileManager fileManager = new FileManager();

            string[] lines = fileManager.readStringsFromFile(pathToBasket);

            // Заполняем массив данными из файла (i = 1 т.к. первая строка в тхт файле это шапка таблицы)

            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split('\t');
                // Заполнение таблицы
                tableBasketProducts.Rows.Add(Convert.ToInt32(values[0]), values[1], values[2], values[3], Convert.ToInt32(values[4]), Convert.ToInt32(values[5]), Convert.ToInt32(values[6]));
            }
        }

        public void deleteProductFromBasket(int index)
        {
            // Проверяем, существует ли файл
            if (!File.Exists(pathToBasket))
            {
                Console.WriteLine("Файл не найден.");
                return;
            }

            // Читаем все строки из файла
            var lines = File.ReadAllLines(pathToBasket).ToList();

            // Проверяем, корректен ли номер строки
            if (index < 1 || index > lines.Count)
            {
                Console.WriteLine("Номер строки вне диапазона.");
                return;
            }

            // Удаляем строку с указанным номером (индекс на 1 меньше, так как индексация с 0)
            lines.RemoveAt(index);

            // Перезаписываем файл без удалённой строки
            File.WriteAllLines(pathToBasket, lines);

            //Console.WriteLine($"Строка {index} успешно удалена.");
        }


        public void addFilteringProducts(ComboBox comboBoxFilter)
        {
            // Добавляем элементы в ComboBox - значения брендов
            comboBoxFilter.Items.Add("         "); // Добавить опцию для сброса фильтра
            var ids = tableBasketProducts.AsEnumerable().Select(row => row.Field<int>("Id")).Distinct().OrderBy(id => id).ToList();
            comboBoxFilter.Items.AddRange(ids.Select(id => id.ToString()).ToArray());
            comboBoxFilter.SelectedIndex = 0; // Установить первый элемент выбранным
        }

        //фильтрация для корзины
        public DataView FilteringProducts(ComboBox comboBoxFilter, DataGridView dataGridViewBasket)
        {

            // Получить выбранное значение
            string selectedId = comboBoxFilter.SelectedItem.ToString();

            if (selectedId == "         ")
            {
                // Сбросить фильтр
                DataView view = tableBasketProducts.DefaultView;
                view.RowFilter = string.Empty; // Удаляем фильтр
                dataGridViewBasket.DataSource = view; // Привязываем оригинальные данные
                return view;

            }
            else
            {
                // Создать DataView из оригинальной таблицы
                DataView view = tableBasketProducts.DefaultView;
                view.RowFilter = $"Convert(Id, 'System.String') LIKE '{selectedId}'";

                // Привязать отфильтрованные данные к DataGridView
                dataGridViewBasket.DataSource = view;
                return view;
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        public int UpdateFilteredSum(DataView view)
        {
            // Подсчет суммы
            return view.Cast<DataRowView>().Sum(row => row.Row.Field<int>("Price (USD)")); // Укажите имя колонки с ценой
        }


    }
}
