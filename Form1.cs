using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Market_try;


namespace FormMarket
{
    public partial class Form1 : Form
    {
        /*
         private void buttonToFiltrBrand_Click(object sender, EventArgs e)
        {
         dataGridView1.Hide();// прячем таблицу которую разместили до этого в форме
         
         string filtr_value = filtrValueField.Text; //текстбох для ввода фильтра

         DataTable table2 = new DataTable();


         table2.Columns.Add("Brand", typeof(string));
                table.Columns.Add("Model", typeof(string));
                table.Columns.Add("Submodel", typeof(string));
                table.Columns.Add("Memory", typeof(int));
                table.Columns.Add("Quantity", typeof(int));



                for (int i = 0; i<shop.goods.Count; i++)
                {
                    if (shop.goods[i].Brand == filtr_value)
                    table.Rows.Add(shop.goods[i].Brand, shop.goods[i].Model, shop.goods[i].Submodel, shop.goods[i].Memory, shop.goods[i].Quantity);
                }

        dataGridView2.DataSource = table;
        }
         */



        private User user;
        private string cellValue;
        private DataTable table;
        public Form1()
        {
            InitializeComponent();
            user = new User();// создаем объект User

            dataGridView1.Hide();// прячем таблицу которую разместили до этого в форме

            // заполняем таблицу
            Shop shop = new Shop();

            table = new DataTable();


            table.Columns.Add("Brand", typeof(string));
            table.Columns.Add("Model", typeof(string));
            table.Columns.Add("Submodel", typeof(string));
            table.Columns.Add("Memory", typeof(int));
            table.Columns.Add("Quantity", typeof(int));

            // читаем из тхт файла и заполняем в список поля User каталог товаров
            shop.goodsToShop();

            // Заполнение таблицы
            for (int i = 0; i < shop.goods.Count; i++)
            {
                table.Rows.Add(shop.goods[i].Brand, shop.goods[i].Model, shop.goods[i].Submodel, shop.goods[i].Memory, shop.goods[i].Quantity);
            }

            // Привязка данных к DataGridView
            dataGridView1.DataSource = table;

            // Инициализация ComboBox уникальными значениями брендов
            comboBoxFilter.Items.Add("         "); // Добавить опцию для сброса фильтра
            var brands = shop.goods.Select(g => g.Brand).Distinct().ToList();
            comboBoxFilter.Items.AddRange(brands.ToArray());
            comboBoxFilter.SelectedIndex = 0; // Установить первый элемент выбранным


        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //==============================================================================================
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {


            // Получить выбранное значение
            string selectedBrand = comboBoxFilter.SelectedItem.ToString();

            if (selectedBrand == "         ")
            {
                // Сбросить фильтр
                DataView view = table.DefaultView;
                view.RowFilter = string.Empty; // Удаляем фильтр
                dataGridView1.DataSource = view; // Привязываем оригинальные данные
            }
            else
            {
                // Создать DataView из оригинальной таблицы
                DataView view = table.DefaultView;
                view.RowFilter = $"Brand = '{selectedBrand}'";

                // Привязать отфильтрованные данные к DataGridView
                dataGridView1.DataSource = view;
            }
        }
        //==============================================================================================

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Получаем текст из текстового поля
            string searchText = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Введите текст для поиска.");
                return;
            }

            // Создаем DataView для фильтрации
            DataView view = table.DefaultView;

            // Формируем условие фильтрации
            StringBuilder filter = new StringBuilder();

            foreach (DataColumn column in table.Columns)
            {
                if (column.DataType == typeof(string))
                {
                    if (filter.Length > 0) filter.Append(" OR ");
                    filter.Append($"{column.ColumnName} LIKE '%{searchText}%'");
                }
            }

            // Проверяем, что фильтр сформирован
            if (filter.Length == 0)
            {
                MessageBox.Show("Поиск возможен только по строковым столбцам.");
                return;
            }

            // Применяем фильтр
            try
            {
                view.RowFilter = filter.ToString();
                dataGridView1.DataSource = view;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при поиске: {ex.Message}");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Сбросить фильтр
            DataView view = table.DefaultView;
            view.RowFilter = string.Empty; // Удаляем фильтр
            dataGridView1.DataSource = view; // Привязываем оригинальные данные
            textBoxSearch.Clear();
        }

        //==============================================================================================

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (user.logPas.id != 0)
            {
                // Создаем экземпляр второй формы
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("You are not authorized");
            }

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passwordUser = passwordField.Text;

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (user.Autorithation(loginUser, passwordUser))
            {
                //MessageBox.Show("Ok!!");
                loginbutton.Hide();     //скрываем поле логин
                loginField.Hide();      //скрываем поле пароль
                passwordField.Hide();   //скрываем кнопку логин
                RegistrationButton.Hide();//скрываем кнопку регистрация

                /////////////////////////////////////////////////////////////
                dataGridView1.Show();   // показываем ранее созданую таблицу


            }
            else
            {
                MessageBox.Show("Not Ok!!");
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passwordUser = passwordField.Text;

            if (user.Registration(loginUser, passwordUser))
            {
                MessageBox.Show("Вы зарегистрированы!!!");
                loginbutton.Hide();     //скрываем поле логин
                loginField.Hide();      //скрываем поле пароль
                passwordField.Hide();   //скрываем кнопку логин
                RegistrationButton.Hide();//скрываем кнопку регистрация
                /////////////////////////////////////////////////////////////
                dataGridView1.Show();   // показываем ранее созданую таблицу

            }
            else
            {
                MessageBox.Show("Такой Логин или Пароль уже существуют");
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void buttonToBuy_Click(object sender, EventArgs e)
        {
            // Проверяем, что выбрана строка
            if (dataGridView1.CurrentRow != null)
            {
                // Сохраняем значение первой ячейки выбранной строки
                for (int i = 0; i < (dataGridView1.Rows.Count + 1); i++)
                {
                    cellValue += dataGridView1.CurrentRow.Cells[i].Value?.ToString() + "\t";//!!!!!!! значение и которое потом запишется в тхт файл корзины)
                }
                MessageBox.Show($"Содержимое первой ячейки строки скопировано: {cellValue}");
                File.AppendAllText("market_goods_korzina.txt", cellValue + user.logPas.id + "\n");
                cellValue = "";
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку.");
            }
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////


    }
}
