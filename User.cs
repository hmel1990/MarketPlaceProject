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

        internal LoginPassword currentUserLoginPassword = new LoginPassword();

        private List<LoginPassword> usersLoginPasswordList = new List<LoginPassword>();

        #region сеттеры и геттеры
        public void loginSetter (string login)
        {
            //Console.WriteLine("Введите Логин");
            //string login = Console.ReadLine();
            currentUserLoginPassword.login = login;
        }

        public void accessSetter(string access)
        {
            //Console.WriteLine("Введите Логин");
            //string login = Console.ReadLine();
            currentUserLoginPassword.access = access;
        }
        public void idSetter(string userID)
        { currentUserLoginPassword.userID = userID; }

        public void passwordSetter(string password)
        {
            //Console.WriteLine("Введите Пароль");
            //string password = Console.ReadLine();
            currentUserLoginPassword.password = password;
        }
        #endregion

        #region конструктор
        public User ()
        {
            currentUserLoginPassword.access = "";

            // Считываем все строки из файлаqqq
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
                usersLoginPasswordList.Add(new LoginPassword(lines[i]));
            }
            //logPas.userID = "0";

        }
        #endregion

        #region регистрация и авторизация


        public bool Autorithation(string loginUser, string passwordUser /*User user, ,Admin admin, Seller seller, Customer customer*/) //параметры х у принимаются из виндовс форм
        {

            foreach (LoginPassword lp in usersLoginPasswordList) 
            {
                if (lp.login == loginUser && lp.password == passwordUser)
                {
                    accessSetter(lp.access);
                    loginSetter(loginUser);
                    passwordSetter(passwordUser);
                    idSetter(lp.userID);
                     /*
                    //______________________________________________________________________________________
                       switch (currentUserLoginPassword.access)
                    {
                        case "": // Без сортировки
                            Console.WriteLine("Пользователь отсутствует");
                            break;
                        case "admin": // админ
                                      //Admin admin = new Admin();
                            admin.currentUserLoginPassword.access = "admin";
                            admin.currentUserLoginPassword.userID = currentUserLoginPassword.userID;
                            break;
                        case "seller": // продавец
                                       //Seller seller = new Seller();
                            seller.currentUserLoginPassword.access = "seller";
                            seller.currentUserLoginPassword.userID = currentUserLoginPassword.userID;
                            break;
                        case "customer": // покупатель
                                         //Customer customer = new Customer();
                            customer.currentUserLoginPassword.access = "customer";
                            customer.currentUserLoginPassword.userID = currentUserLoginPassword.userID;
                            break;
                    }
                    //______________________________________________________________________________________
                      */
                   

                    //Console.WriteLine("Все ОК!!!");
                    return true;
                }
            }
            if (currentUserLoginPassword.access == "")
            {
                return false;
                //Console.WriteLine("Логин или пароль неверные");
                //throw new Exception();
            }
            return false;
        }
        
          private bool сheckOut(string x, string y)
        {
            loginSetter(x);
            passwordSetter(y);

            foreach (LoginPassword lp in usersLoginPasswordList)
            {

                if (lp.login == currentUserLoginPassword.login && lp.password == currentUserLoginPassword.password)
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
                usersLoginPasswordList.Add(new LoginPassword()); // добавляем в список еще один объект
                currentUserLoginPassword.access = "customer"; // устанавливаем access == customer
                currentUserLoginPassword.userID = Convert.ToString(usersLoginPasswordList.Count());
                usersLoginPasswordList[(usersLoginPasswordList.Count() - 1)].access = "customer";            //заполняем новый объект в массиве
                usersLoginPasswordList[(usersLoginPasswordList.Count() - 1)].login = currentUserLoginPassword.login;         //заполняем новый объект в массиве
                usersLoginPasswordList[(usersLoginPasswordList.Count() - 1)].password = currentUserLoginPassword.password;   //заполняем новый объект в массиве
                usersLoginPasswordList[(usersLoginPasswordList.Count() -1)].userID = Convert.ToString(usersLoginPasswordList.Count());
                File.AppendAllText("loginPassword.txt", currentUserLoginPassword.access + "\t" + currentUserLoginPassword.login + "\t" + currentUserLoginPassword.password + "\t" + currentUserLoginPassword.userID + "\n"); //записываем строку с новым пользователев в тхт файл

                return true;
            }
            else {return false; }
        }
        #endregion

        //#region добавление в корзину
        //public void addToBasket(string cellValue)
        //{
        //    File.AppendAllText("market_goods_korzina.txt", cellValue + currentUserLoginPassword.access + "\n");
        //}
        //#endregion
    }
}
