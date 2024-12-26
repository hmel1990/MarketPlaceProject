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

using static System.Windows.Forms.DataFormats;
using Microsoft.VisualBasic.ApplicationServices;

namespace FormMarket
{
    public partial class Form2 : Form
    {
        internal DataTable tableProducts;
        internal DataTable tableUsers;
        internal Shop shop;

        internal Seller seller;
        internal Admin admin;

        private string pathToUsers = "loginPassword.txt";
        private string pathToProducts = "market_goods.txt";

        public Form2()
        {
            InitializeComponent();
            seller = new Seller();
            admin = new Admin();
            shop = new Shop();
            tableProducts = shop.table;
            dataGridViewProducts.DataSource = tableProducts;
            //___________________________________________________
            tableUsers = new DataTable();

            tableUsers.Columns.Add("Access", typeof(string));
            tableUsers.Columns.Add("Login", typeof(string));
            tableUsers.Columns.Add("Password", typeof(string));
            tableUsers.Columns.Add("Id", typeof(string));

            for (int i = 0; i < admin.listOfUsers.Count; i++)
            {
                tableUsers.Rows.Add(admin.listOfUsers[i].access, admin.listOfUsers[i].login, admin.listOfUsers[i].password, admin.listOfUsers[i].userID);
            }

            dataGridViewUsers.DataSource = tableUsers;
        }


        private void Form2_Load(object sender, EventArgs e){}

        private void deleteUserFromList_Click(object sender, EventArgs e)
        {
            // Проверяем, что выбрана строка
            if (dataGridViewUsers.CurrentRow != null)
            {
                int index = (dataGridViewUsers.CurrentRow.Index + 1);
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
            if (dataGridViewProducts.CurrentRow != null)
            {
                int index = (dataGridViewProducts.CurrentRow.Index + 1);
                seller.deleteGoodsFromShop(index);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку.");
            }
        }

       
        private void saveUsersToFile_Click(object sender, EventArgs e)
        {
            FileManager fm = new FileManager();
            fm.writeUsersGridViewToFile(tableUsers, pathToUsers);
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
                    tableUsers.Rows.Add(adm.access, adm.login, adm.password, adm.userID);
                }

                // Привязываем обновленную таблицу к DataGridView
                dataGridViewUsers.DataSource = tableUsers;
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
                var headers = string.Join("\t", tableProducts.Columns.Cast<DataColumn>().Select(column => column.ColumnName));
                writer.WriteLine(headers);

                // Запись данных строк
                foreach (DataRow row in tableProducts.Rows)
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
            if (tableProducts != null)
            {

                tableProducts.Clear();
                shop.products.Clear();
                shop.productsToShop(pathToProducts);

                foreach (var product in shop.products)
                {
                    tableProducts.Rows.Add(product.Brand, product.Model, product.Submodel, product.Memory, product.Quantity);
                }

                // Привязываем обновленную таблицу к DataGridView
                dataGridViewProducts.DataSource = tableProducts;

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
