using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMarket
{
    internal class Basket
    {
        private string pathToBasket = "market_goods_korzina.txt";
        public void addProductToBasket(Customer customer, DataGridView dataGridView1, string cellValue)
        {
             
            // Проверяем, что выбрана строка
            if (dataGridView1.CurrentRow != null)
            {
                // Сохраняем значение первой ячейки выбранной строки
                for (int i = 0; i < (dataGridView1.Columns.Count); i++)
                {
                    cellValue += dataGridView1.CurrentRow.Cells[i].Value?.ToString() + "\t";//!!!!!!! значение и которое потом запишется в тхт файл корзины)
                }
                cellValue = cellValue + "\t" + customer.logPas.userID;
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

    }
}
