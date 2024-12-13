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
        
          public bool сheckOut(string x, string y)
        {
            loginSetter(x);
            passwordSetter(y);

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

        public bool Registration(string x, string y)
        {
            //while (!сheckOut(x,y)) 
            //{
            //    Console.WriteLine("Попробуйте снова.");
            //}

            if (сheckOut(x, y))
            {
                data.Add(new LoginPassword()); // добавляем в список еще один объект
                logPas.id = data.Count(); // устанавливаем id по количеству строк в массиве (нулевая строка єто шапка)
                data[(data.Count() - 1)].id = data.Count();            //заполняем новый объект в массиве
                data[(data.Count() - 1)].login = logPas.login;         //заполняем новый объект в массиве
                data[(data.Count() - 1)].password = logPas.password;   //заполняем новый объект в массиве
                File.AppendAllText("loginPassword.txt", logPas.id + "\t" + logPas.login + "\t" + logPas.password + "\n"); //записываем строку с новым пользователев в тхт файл
                return true;
            }
            else {return false; }
        }
         
       

    }
}
