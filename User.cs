using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_try
{
    internal class User
    {
        //private int id = 0;
        //private string login;
        //private string password;

        internal LoginPassword logPas = new LoginPassword();

        private List<LoginPassword> data = new List<LoginPassword>();

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

        public User ()
        {
            logPas.id = 0;

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
                data.Add(new LoginPassword(lines[i]));
            }

        }

        public bool Autorithation(string x, string y) //параметры х у принимаются из виндовс форм
        {
            loginSetter(x);
            passwordSetter(y);

            foreach (LoginPassword lp in data) 
            {
                if (lp.login == logPas.login && lp.password == logPas.password)
                {
                    logPas.id = lp.id;
                    //Console.WriteLine("Все ОК!!!");
                    return true;
                }
            }
            if (logPas.id == 0)
            {
                //Console.WriteLine("Логин или пароль неверные");
                //throw new Exception();
            }
                return false;
        }
        /*
          public bool сheckOut()
        {
            loginSetter();
            passwordSetter();

            foreach (LoginPassword lp in data)
            {

                if (lp.login == logPas.login && lp.password == logPas.password)
                {
                    Console.WriteLine("Такой Логин или Пароль уже существуют");
                    return false;
                }

            }
            return true;
        }

        public void Registration()
        {
            while (!сheckOut()) 
            {
                Console.WriteLine("Попробуйте снова.");
            }
 

             data.Add(new LoginPassword());
             logPas.id = data.Count();
             data[(data.Count() - 1)].id = data.Count();
             data[(data.Count() - 1)].login = logPas.login;
             data[(data.Count() - 1)].password = logPas.password;
             File.AppendAllText("loginPassword.txt", logPas.id + "\t" + logPas.login + "\t" + logPas.password + "\n");
                
        }
         */
       

    }
}
