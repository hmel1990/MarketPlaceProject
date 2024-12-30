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
    public partial class Form3 : Form
    {
        internal DataTable tableProducts;
        internal DataTable tableBasketProducts;
        internal Shop shop;

        internal Seller seller;
        internal Admin admin;

        private string pathToUsers = "loginPassword.txt";
        private string pathToProducts = "market_goods.txt";
        private string pathToBusket = "market_goods_korzina.txt";

        internal Basket basket;

        public Form3()
        {
            InitializeComponent();
            seller = new Seller();
            admin = new Admin();
            shop = new Shop();
            tableProducts = shop.table;
            dataGridViewProducts.DataSource = tableProducts;
            basket = new Basket();
            tableBasketProducts = basket.tableBasketProducts;
            dataGridViewBasket.DataSource = tableBasketProducts;
            basket.addFilteringProducts(comboBoxFilter);

        }

        private void buttonSwitchToMain_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        //удаляем товар из магазина
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

        public void SaveProductsGridViewToFile()
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
        private void saveProductsToFile_Click(object sender, EventArgs e)
        {
            SaveProductsGridViewToFile();
        }

        private void buttonRefreshProdutcs_Click(object sender, EventArgs e)
        {
            RefreshDataProductsGridView();
        }

        private void RefreshDataProductsGridView()
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

        private void saveUsersToFile_Click(object sender, EventArgs e)
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
                //Admin admin = new Admin();
                //admin.usersToList();

                //foreach (var adm in admin.listOfUsers)
                //{
                //    tableBasketProducts.Rows.Add(adm.access, adm.login, adm.password, adm.userID);
                //}

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
