﻿//using Market_try;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMarket
{
    public class Admin: FormMarket.User
    {
        //private List<Product> adminBasketProducts = new List<Product>();
        private string pathToUsersData = "E:\\STEP\\C_sharp .Net\\MarketPlace\\MarketplaceProject\\bin\\Debug\\net9.0-windows\\loginPassword.txt";

        internal List<LoginPassword> listOfUsers = new List<LoginPassword>();

        public Admin ()
        {
            currentUserLoginPassword.access = "";
            usersToList();
        }
        public void usersToList()
        {
            // Считываем все строки из файла
            string[] lines = File.ReadAllLines(pathToUsersData);

            // Проверяем, есть ли строки в файле
            if (lines.Length == 0)
            {
                Console.WriteLine("Файл пуст.");
                return;
            }

            // Заполняем массив данными из файла (i = 1 т.к. первая строка в тхт файле это шапка таблицы)
            for (int i = 1; i < lines.Length; i++)
            {
                listOfUsers.Add(new LoginPassword(lines[i]));
            }

        }

        public void deleteUserFromList(int index)
        {
            // Проверяем, существует ли файл
            if (!File.Exists(pathToUsersData))
            {
                Console.WriteLine("Файл не найден.");
                return;
            }

            // Читаем все строки из файла
            var lines = File.ReadAllLines(pathToUsersData).ToList();

            // Проверяем, корректен ли номер строки
            if (index < 1 || index > lines.Count)
            {
                Console.WriteLine("Номер строки вне диапазона.");
                return;
            }

            // Удаляем строку с указанным номером (индекс на 1 меньше, так как индексация с 0)
            lines.RemoveAt(index);

            // Перезаписываем файл без удалённой строки
            File.WriteAllLines(pathToUsersData, lines);

            //Console.WriteLine($"Строка {index} успешно удалена.");
        }

    }
}
