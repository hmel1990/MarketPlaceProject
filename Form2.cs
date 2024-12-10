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

namespace FormMarket
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
         private void Form2_Load(object sender, EventArgs e)
        {
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
        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы
            Form1 form1 = new Form1();

            // Показываем первую форму
            form1.Show();

            // Закрываем текущую форму
            this.Close();
        }


    }
}
