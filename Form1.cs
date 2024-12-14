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
        public Form1()
        {
            InitializeComponent();
            user = new User();// создаем объект User

            dataGridView1.Hide();// прячем таблицу которую разместили до этого в форме
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

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

                Shop shop = new Shop();

                DataTable table = new DataTable();


                table.Columns.Add("Brand", typeof(string));
                table.Columns.Add("Model", typeof(string));
                table.Columns.Add("Submodel", typeof(string));
                table.Columns.Add("Memory", typeof(int));
                table.Columns.Add("Quantity", typeof(int));


                shop.goodsToShop();

                for (int i = 0; i < shop.goods.Count; i++)
                {
                    table.Rows.Add(shop.goods[i].Brand, shop.goods[i].Model, shop.goods[i].Submodel, shop.goods[i].Memory, shop.goods[i].Quantity);
                }

                dataGridView1.DataSource = table;
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

                Shop shop = new Shop();

                DataTable table = new DataTable();


                table.Columns.Add("Brand", typeof(string));
                table.Columns.Add("Model", typeof(string));
                table.Columns.Add("Submodel", typeof(string));
                table.Columns.Add("Memory", typeof(int));
                table.Columns.Add("Quantity", typeof(int));


                shop.goodsToShop();

                for (int i = 0; i < shop.goods.Count; i++)
                {
                    table.Rows.Add(shop.goods[i].Brand, shop.goods[i].Model, shop.goods[i].Submodel, shop.goods[i].Memory, shop.goods[i].Quantity);
                }

                dataGridView1.DataSource = table;
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
