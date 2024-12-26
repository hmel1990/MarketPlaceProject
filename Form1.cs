using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FormMarket
{
    public partial class Form1 : Form
    { 
        private Shop shop;
        private string cellValue;
        internal DataTable table;
        private User user;
        private Customer customer;
        private Seller seller;
        private Admin admin;
        private Basket basket;
        
        //Конструктор
        public Form1()
        {
            InitializeComponent();
            user = new User();// создаем объект User www
            seller = new Seller();
            admin = new Admin();
            customer = new Customer();
            shop = new Shop();
            basket = new Basket();


            // читаем из тхт файла и заполняем в список поля User каталог товаров
            // заполняем таблицу
            table = shop.table;

            // Привязка данных к DataGridView
            dataGridView1.DataSource = table;

            //сортировка и фильтр
            shop.addSortingProducts(comboBoxSort);
            shop.addFilteringProducts(comboBoxFilter);

        }

        //загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();// прячем таблицу которую разместили до этого в форме

        }

        // Обработчик изменения выбранного элемента ComboBox - фильтр
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            shop.FilteringProducts(comboBoxFilter, dataGridView1);
        }


        // Обработчик изменения выбранного элемента ComboBox - сортировка
        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            shop.SortingProducts(comboBoxSort, dataGridView1);
           
        }



        //Авторизация 
        private void loginbutton_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passwordUser = passwordField.Text;
                       
            if (user.Autorithation(user, loginUser, passwordUser, admin, seller,customer))
            {
                //MessageBox.Show("Ok!!");
                loginbutton.Hide();     //скрываем поле логин
                loginField.Hide();      //скрываем поле пароль
                passwordField.Hide();   //скрываем кнопку логин
                RegistrationButton.Hide();//скрываем кнопку регистрация
                dataGridView1.Show();   // показываем ранее созданую таблицу
            }
            else
            {
                MessageBox.Show("Логин или пароль неверные!!!");
            }
        }

        //Регистрация
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
                dataGridView1.Show();   // показываем ранее созданую таблицу

            }
            else
            {
                MessageBox.Show("Такой Логин или Пароль уже существуют");
            }
        }
        private void buttonToBuy_Click(object sender, EventArgs e)
        {
            basket.addProductToBasket(customer, dataGridView1, cellValue);
            //MessageBox.Show( customer.idGetter());

        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //переключиться на форму 2
        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (user.logPas.access == "seller" | user.logPas.access == "admin")
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
        //Кнопка поиска товара
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

        //Кнопка сброса фильтра
        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Сбросить фильтр
            DataView view = table.DefaultView;
            view.RowFilter = string.Empty; // Удаляем фильтр
            dataGridView1.DataSource = view; // Привязываем оригинальные данные
            textBoxSearch.Clear();
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        //Кнопка обновить данные после редактирования
        private void RefreshDataGridView()
        {
            if (table != null)
            {
                // Обновляем данные в таблице
                table.Clear();

                //Shop shop = new Shop();

                // Очищаем список продуктов перед обновлением
                shop.products.Clear();
                shop.productsToShop("market_goods.txt");

                foreach (var product in shop.products)
                {
                    table.Rows.Add(product.Brand, product.Model, product.Submodel, product.Memory, product.Quantity);
                }

                // Привязываем обновленную таблицу к DataGridView
                dataGridView1.DataSource = table;
            }
            else
            {
                MessageBox.Show("Таблица не инициализирована.");
            }
        }
    }
}
