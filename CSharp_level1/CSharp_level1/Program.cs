// Чернышов Виктор. Урок 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    class Program
    {
        static void Task1()
        {
            // Написать метод, возвращающий минимальное из трёх чисел.
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());
            int min;
            if (a < b) min = a < c ? a : c;
            else min = b < c ? b : c;
            Console.WriteLine($"Минимальным из этих трех чисел является: {min}");
        }
        static void Task2()
        {
            // Написать метод подсчета количества цифр числа.
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (n != 0)
            {
                n /= 10;
                count++;
            }
            Console.WriteLine($"Количество цифр: {count}");
        }
        static void Task3()
        {
            /* С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных
             * положительных чисел. */
            int sum = 0;
            int n = 0;
            do
            {
                Console.Write("Введите число: ");
                n = int.Parse(Console.ReadLine());
                if (n > 0 && n % 2 != 0) sum += n;
            }
            while (n != 0);
            Console.WriteLine("Сумм всех нечётных положительных чисел равна: " + sum);
        }
        static bool Task4()
        {
            /* Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На
             * выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password:
             * GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
             * вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью
             * цикла do while ограничить ввод пароля тремя попытками. */
            int count = 0;
            Console.WriteLine("Требуется авторизация");
            do
            {
                Console.Write("Логин: ");
                string log = Console.ReadLine();
                Console.Write("Пароль: ");
                string pas = Console.ReadLine();
                if (log == "root" && pas == "GeekBrains") return true;
                Console.WriteLine("Отказано в доступе");
                count++;
            }
            while (count < 3);
            return false;
        }
        static int Task7(int a, int b)
        {
            /* a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
             * б) *Разработать рекурсивный метод, который считает сумму чисел от a до b. */
            Console.Write(a + " ");
            if (a < b) a += Task7(a + 1, b);
            return a;
        }
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            // Task3();
            // if (Task4()) Console.WriteLine("Авторизация прошла успешно");
            int a = 1;
            int b = 5;
            Console.WriteLine($"\nСумма чисел от {a} до {b} равна {Task7(a, b)}");

            Console.ReadLine();
        }
    }
}
