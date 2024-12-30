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
using System.Reflection.Emit;

namespace FormMarket
{
    public partial class Form2 : Form
    {
        internal DataTable tableProducts;
        internal DataTable tableUsers;
        internal DataTable tableBasketProducts;

        internal Shop shop;
        internal Basket basket;


        internal Seller seller;
        internal Admin admin;

        private string pathToUsers = "loginPassword.txt";
        private string pathToProducts = "market_goods.txt";
        private string pathToBusket = "market_goods_korzina.txt";


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

            basket = new Basket();
            tableBasketProducts = basket.tableBasketProducts;
            dataGridViewBasket.DataSource = tableBasketProducts;
            basket.addFilteringProducts(comboBoxFilter);

            for (int i = 0; i < admin.listOfUsers.Count; i++)
            {
                tableUsers.Rows.Add(admin.listOfUsers[i].access, admin.listOfUsers[i].login, admin.listOfUsers[i].password, admin.listOfUsers[i].userID);
            }

            dataGridViewUsers.DataSource = tableUsers;


        }


        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(230, 230, 250);
        }

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
                    tableProducts.Rows.Add(product.Brand, product.Model, product.Submodel, product.Memory, product.Quantity, product.Price);
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

        //________________________________________________________________________________

        private void deleteProductFromBasket_Click(object sender, EventArgs e)
        {
            // Проверяем, что выбрана строка
            if (dataGridViewBasket.CurrentRow != null)
            {
                int index = (dataGridViewBasket.CurrentRow.Index + 1);
                basket.deleteProductFromBasket(index);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку.");
            }
        }

        private void saveProductsToBascketFile_Click(object sender, EventArgs e)
        {
            FileManager fm = new FileManager();
            fm.writeUsersGridViewToFile(tableBasketProducts, pathToBusket);
        }

        private void RefreshBasketProductsGrid_Click(object sender, EventArgs e)
        {
            RefreshBasketProductsGridView();
        }
        private void RefreshBasketProductsGridView()
        {
            if (tableBasketProducts != null)
            {
                // Обновляем данные в таблице
                tableBasketProducts.Clear();
                basket.tableBasketProducts.Clear();
                basket.fillBasket(tableBasketProducts);

                // Привязываем обновленную таблицу к DataGridView
                dataGridViewBasket.DataSource = tableBasketProducts;
            }
            else
            {
                MessageBox.Show("Таблица не инициализирована.");
            }
        }

        //Обработчик изменения выбранного элемента ComboBox - фильтр
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView view = basket.FilteringProducts(comboBoxFilter, dataGridViewBasket);
            int totalSum = basket.UpdateFilteredSum(view);
            labelFilteredSum.Text = $"Сумма: {totalSum}$";
        }


    }
}
