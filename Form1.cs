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
        private User user;
        public Form1()
        {
            InitializeComponent();
            user = new User();

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
            //User user = new User();

            if (user.Autorithation(loginUser, passwordUser))
            {
                MessageBox.Show("Ok!!");
            }
            else
            {
                MessageBox.Show("Not Ok!!");
            }
        }


    }
}
