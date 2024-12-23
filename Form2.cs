using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Market_try;
using static System.Windows.Forms.DataFormats;
using Microsoft.VisualBasic.ApplicationServices;

namespace FormMarket
{
    public partial class Form2 : Form
    {
        internal DataTable table;
        internal DataTable tableUsers;

        internal Seller seller;
        internal Admin admin;



        public Form2()
        {
            InitializeComponent();
            seller = new Seller();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            Shop shop = new Shop();
            shop.productsToShop();

            table = new DataTable();

            table.Columns.Add("Brand", typeof(string));
            table.Columns.Add("Model", typeof(string));
            table.Columns.Add("Submodel", typeof(string));
            table.Columns.Add("Memory", typeof(int));
            table.Columns.Add("Quantity", typeof(int));



            for (int i = 0; i < shop.products.Count; i++)
            {
                table.Rows.Add(shop.products[i].Brand, shop.products[i].Model, shop.products[i].Submodel, shop.products[i].Memory, shop.products[i].Quantity);
            }

            dataGridView2.DataSource = table;


            admin = new Admin();
            admin.usersToList();

            tableUsers = new DataTable();

            tableUsers.Columns.Add("Access", typeof(string));
            tableUsers.Columns.Add("Login", typeof(string));
            tableUsers.Columns.Add("Password", typeof(string));
            for (int i = 0; i < admin.listOfUsers.Count; i++)
            {
                tableUsers.Rows.Add(admin.listOfUsers[i].access, admin.listOfUsers[i].login, admin.listOfUsers[i].password);
            }

            dataGridView3.DataSource = tableUsers;
        }

        private void deleteUserFromList_Click(object sender, EventArgs e)
        {
            // Проверяем, что выбрана строка
            if (dataGridView3.CurrentRow != null)
            {
                int index = (dataGridView3.CurrentRow.Index + 1);
                admin.deleteUserFromList(index);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку.");
            }
        }





        private void deleteGoodsFromShop_Click(object sender, EventArgs e)
        {
            // Проверяем, что выбрана строка
            if (dataGridView2.CurrentRow != null)
            {
                int index = (dataGridView2.CurrentRow.Index + 1);
                seller.deleteGoodsFromShop(index);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку.");
            }
        }

        public void SaveUsersGridViewToFile()
        {
            using (var writer = new StreamWriter("loginPassword.txt"))
            {
                // Запись заголовков
                var headers = string.Join("\t", tableUsers.Columns.Cast<DataColumn>().Select(column => column.ColumnName));
                writer.WriteLine(headers);

                // Запись данных строк
                foreach (DataRow row in tableUsers.Rows)
                {
                    var values = string.Join("\t", row.ItemArray);
                    writer.WriteLine(values);
                }
            }
        }
        private void saveUsersToFile_Click(object sender, EventArgs e)
        {
            SaveUsersGridViewToFile();
        }

        private void buttonUsersRefresh_Click(object sender, EventArgs e)
        {
            RefreshUsersGridView();
        }

        private void RefreshUsersGridView()
        {
            if (tableUsers != null)
            {
                // Обновляем данные в таблице
                tableUsers.Clear();

                Admin admin = new Admin();
                admin.usersToList();

                foreach (var adm in admin.listOfUsers)
                {
                    tableUsers.Rows.Add(adm.access, adm.login, adm.password);
                }

                // Привязываем обновленную таблицу к DataGridView
                dataGridView3.DataSource = tableUsers;
            }
            else
            {
                MessageBox.Show("Таблица не инициализирована.");
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////

        public void SaveDataGridViewToFile()
        {
            using (var writer = new StreamWriter("market_goods.txt"))
            {
                // Запись заголовков
                var headers = string.Join("\t", table.Columns.Cast<DataColumn>().Select(column => column.ColumnName));
                writer.WriteLine(headers);

                // Запись данных строк
                foreach (DataRow row in table.Rows)
                {
                    var values = string.Join("\t", row.ItemArray);
                    writer.WriteLine(values);
                }
            }
        }
        private void saveToFile_Click(object sender, EventArgs e)
        {
            SaveDataGridViewToFile();
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            if (table != null)
            {
                // Обновляем данные в таблице
                table.Clear();

                Shop shop = new Shop();
                shop.productsToShop();

                foreach (var product in shop.products)
                {
                    table.Rows.Add(product.Brand, product.Model, product.Submodel, product.Memory, product.Quantity);
                }

                // Привязываем обновленную таблицу к DataGridView
                dataGridView2.DataSource = table;
            }
            else
            {
                MessageBox.Show("Таблица не инициализирована.");
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
