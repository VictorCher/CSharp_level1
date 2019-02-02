// Чернышов Виктор. Урок 4
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    class Program
    {
        public struct Account
        {
            string Login;
            string Password;
            public Account(string log, string pas)
            {
                this.Login = log;
                this.Password = pas;
            }
        }
        static bool Task4()
        {
            /* Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На
             * выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password:
             * GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
             * вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью
             * цикла do while ограничить ввод пароля тремя попытками. Решить задачу, считывая логин и пароль
             * из файла в массив. Создать структуру Account, содержащую Login и Password.*/
            Console.Write("Авторизация...");
            StreamReader file = new StreamReader("data.txt");
            string[] mas = new string[2];     
            bool valid = false;
            mas[0] = file.ReadLine();
            mas[1] = file.ReadLine();
            if (mas[0] == "root" && mas[1] == "GeekBrains")
            {
                valid = true;
                Console.WriteLine(" прошла успешно!");
            }
            else Console.WriteLine(" отказано в доступе!");
            file.Close();
            Account structure = new Account(mas[0], mas[1]);
            return valid;
        }

        static void Task3()
        {
            StaticClass.GenMas();
            StaticClass.Print(StaticClass.ReadMas());
            StaticClass.Pair(StaticClass.ReadMas());
        }

        static void Main(string[] args)
        {
            Task3();
            //Task4();

            Console.ReadLine();
        }
    }
}
