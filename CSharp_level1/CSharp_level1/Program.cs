// Чернышов Виктор. Урок 5
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CSharp_level1
{
    class Program
    {
        static void Task1()
        {
            /* Создать программу, которая будет проверять корректность ввода логина.Корректным
             * логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита
             * или цифры, при этом цифра не может быть первой без использования регулярных выражений */

            bool flag = false;
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            string correctChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            if (Char.IsDigit(login[0])) goto result;
            if (login.Length < 2 || login.Length > 10) goto result;
            foreach (char c in login)
                if (correctChar.IndexOf(c) == -1) goto result;
            flag = true;
        result:
            if (flag) Console.WriteLine("Всё хорошо");
            else Console.WriteLine("Всё плохо");
        }
        static void Task2()
        {
            /* Разработать статический класс Message , содержащий следующие статические методы для
             * обработки текста:
             * а) Вывести только те слова сообщения, которые содержат не более n букв.
             * б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
             * в) Найти самое длинное слово сообщения.
             * г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
             * д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в
             * него передается массив слов и текст, в качестве результата метод возвращает сколько раз
             * каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary */

            Console.Write("Введите текст: ");
            string userInput = Console.ReadLine();
            Message.Short(userInput, 4);
        }

        static void Main(string[] args)
        {
            //Task1();
            Task2();

            Console.ReadLine();
        }
    }
}