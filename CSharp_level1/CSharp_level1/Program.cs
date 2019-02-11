// Чернышов Виктор. Урок 6
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
            /* Изменить программу вывода таблицы функции так, чтобы можно было передавать функции
             * типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и
             * функцией a*sin(x). */

            Table.PrintTable(delegate (double a, double x) { return a * x * x; }, 2, 0, 3);
            Table.PrintTable(delegate (double a, double x) { return a * Math.Sin(x); }, 2, 0, 3);
        }
        static void Task2()
        {
            /* Модифицировать программу нахождения минимума функции так, чтобы можно было
             * передавать функцию в виде делегата.
             * а) Сделать меню с различными функциями и представить пользователю выбор, для какой
             * функции и на каком отрезке находить минимум. Использовать массив (или список) делегатов,
             * в котором хранятся различные функции.
             * б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она
             * возвращает минимум через параметр (с использованием модификатора out). */

            Console.WriteLine("Выберите номер функции для вычисления:");
            Console.WriteLine("1 - f(x) = x * x - 50 * x + 10"); 
            Console.WriteLine("2 - f(x) = 2 * x");
            Console.WriteLine("3 - f(x) = x ^ 2");
            Console.WriteLine("4 - f(x) = x + 5");
            F[] menu = { FuncMin.F1, FuncMin.F2, FuncMin.F3, FuncMin.F4 };
            F myFunc = menu[int.Parse(Console.ReadLine())-1];
            Console.WriteLine("Укажите на каком отрезке находить минимум");
            Console.Write("начало: ");
            double start = double.Parse(Console.ReadLine());
            Console.Write("конец: ");
            double end = double.Parse(Console.ReadLine());
            Console.Write("Укажите с каким шагом осуществлять подстановку в функцию: ");
            double step = double.Parse(Console.ReadLine());

            double min;
            FuncMin.SaveFunc("data.bin", myFunc, start, end, step);
            FuncMin.Load("data.bin", out min);
            Console.WriteLine("Минимальное значение: " + min);
        }
        static void Task3()
        {
            /* Переделать программу Пример использования коллекций для решения следующих задач:
             * а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
             * б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
             * в) отсортировать список по возрасту студента;
             * г) *отсортировать список по курсу и возрасту студента; */

            Student.Creator();
            int magistr = 0;
            int[] course = new int[7];
            List<Student> list = new List<Student>();
            // Создаем список студентов
            //DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    // Одновременно подсчитываем количество магистров
                    if (int.Parse(s[6]) >= 5) magistr++;
                    // Одновременно подсчитываем количество студентов в возрасте от 18 до 20 на разных курсах
                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20) course[int.Parse(s[6])]++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы" );
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            Console.WriteLine("Количество студентов учащихся на 5 и 6 курсах: " + magistr);
            Console.WriteLine("Количество студентов в возрасте от 18 до 20 лет на каком курсе учатся:");
            for (int c = 1; c < course.Length; c++) Console.WriteLine($"Курс {c} = {course[c]} чел.");

            StudentComparer<Student> cp = new StudentComparer<Student>();
            list.Sort(cp.CompareAge);
            list.Sort(cp.CompareCourse);
            foreach (var v in list)
                Console.WriteLine($"{v.firstName, 9} {v.lastName, 9} {v.university, 4}" +
                $" {v.faculty, 5} {v.department,5} {v.age, 2} {v.course, 2} {v.group, 5} {v.city, 6} ");
        }

        static void Main(string[] args)
        {
            //Task1();
            Task2();
            //Task3();

            Console.ReadLine();
        }
    }
}