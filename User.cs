using FormMarket;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FormMarket
{
    public class User
    {
        private string pathToUsersData = "loginPassword.txt";
        internal LoginPassword logPas = new LoginPassword();

        private List<LoginPassword> usersData = new List<LoginPassword>();

        #region сеттеры и геттеры
        public void loginSetter (string login)
        {
            //Console.WriteLine("Введите Логин");
            //string login = Console.ReadLine();
            logPas.login = login;
        }

        public void accessSetter(string access)
        {
            //Console.WriteLine("Введите Логин");
            //string login = Console.ReadLine();
            logPas.access = access;
        }
        public void idSetter(string userID)
        { logPas.userID = userID; }

        public void passwordSetter(string password)
        {
            //Console.WriteLine("Введите Пароль");
            //string password = Console.ReadLine();
            logPas.password = password;
        }
        #endregion

        #region конструктор
        public User ()
        {
            logPas.access = "";

            // Считываем все строки из файла
            string[] lines = File.ReadAllLines("loginPassword.txt");

            // Проверяем, есть ли строки в файле
            if (lines.Length == 0)
            {
                Console.WriteLine("Файл пуст.");
                return;
            }

            // Заполняем массив данными из файла (i = 1 т.к. первая строка в тхт файле это шапка таблицы)
            for (int i = 1; i < lines.Length; i++)
            {
                usersData.Add(new LoginPassword(lines[i]));
            }

        }
        #endregion

        #region регистрация и авторизация

        //public void idSetter(string loginUser, string passwordUser)
        //{
        //    FileManager fm = new FileManager();
        //    string[] lines = fm.readStringsFromFile(pathToUsersData);
        //    int count = 0;
        //    foreach (string line in lines)
        //    {
        //        count++;
        //        if (line.Contains(loginUser)&& line.Contains(passwordUser))
        //        {
        //           logPas.id = Convert.ToString(count);
        //        }
        //    }
        //}
        public bool Autorithation(User user, string loginUser, string passwordUser, Admin admin, Seller seller, Customer customer) //параметры х у принимаются из виндовс форм
        {

            foreach (LoginPassword lp in usersData) 
            {
                if (lp.login == loginUser && lp.password == passwordUser)
                {
                    accessSetter(lp.access);
                    loginSetter(loginUser);
                    passwordSetter(passwordUser);
                    idSetter(lp.userID);
                    //______________________________________________________________________________________
                    switch (logPas.access)
                    {
                        case "": // Без сортировки
                            Console.WriteLine("Пользователь отсутствует");
                            break;
                        case "admin": // админ
                                      //Admin admin = new Admin();
                            admin.logPas.access = "admin";
                            admin.logPas.userID = logPas.userID;
                            break;
                        case "seller": // продавец
                                       //Seller seller = new Seller();
                            seller.logPas.access = "seller";
                            seller.logPas.userID = logPas.userID;
                            break;
                        case "customer": // покупатель
                                         //Customer customer = new Customer();
                            customer.logPas.access = "customer";
                            customer.logPas.userID = logPas.userID;
                            break;
                    }
                    //______________________________________________________________________________________

                    //Console.WriteLine("Все ОК!!!");
                    return true;
                }
            }
            if (logPas.access == "")
            {
                return false;
                //Console.WriteLine("Логин или пароль неверные");
                //throw new Exception();
            }
            return false;
        }
        
          public bool сheckOut(string x, string y)
        {
            loginSetter(x);
            passwordSetter(y);

            foreach (LoginPassword lp in usersData)
            {

                if (lp.login == logPas.login && lp.password == logPas.password)
                {
                    //Console.WriteLine("Такой Логин или Пароль уже существуют");
                    return false;
                }

            }
            return true;
        }

        public bool Registration(string x, string y)
        {


            if (сheckOut(x, y))
            {
                usersData.Add(new LoginPassword()); // добавляем в список еще один объект
                logPas.access = "customer"; // устанавливаем id == customer
                usersData[(usersData.Count() - 1)].access = "customer";            //заполняем новый объект в массиве
                usersData[(usersData.Count() - 1)].login = logPas.login;         //заполняем новый объект в массиве
                usersData[(usersData.Count() - 1)].password = logPas.password;   //заполняем новый объект в массиве
                File.AppendAllText("loginPassword.txt", logPas.access + "\t" + logPas.login + "\t" + logPas.password + "\n"); //записываем строку с новым пользователев в тхт файл
                return true;
            }
            else {return false; }
        }
        #endregion

        #region добавление в корзину
        public void addToBucket(string cellValue)
        {
            File.AppendAllText("market_goods_korzina.txt", cellValue + logPas.access + "\n");
        }
        #endregion
    }
}
