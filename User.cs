using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_try
{
    public class User
    {
        internal LoginPassword logPas = new LoginPassword();

        private List<LoginPassword> usersData = new List<LoginPassword>();

        #region сеттеры и геттеры
        public void loginSetter (string login)
        {
            //Console.WriteLine("Введите Логин");
            //string login = Console.ReadLine();
            logPas.login = login;
        }

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
        public bool Autorithation(string x, string y) //параметры х у принимаются из виндовс форм
        {
            loginSetter(x);
            passwordSetter(y);

            foreach (LoginPassword lp in usersData) 
            {
                if (lp.login == logPas.login && lp.password == logPas.password)
                {
                    logPas.access = lp.access;

                    //Console.WriteLine("Все ОК!!!");
                    return true;
                }
            }
            if (logPas.access == "")
            {
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
