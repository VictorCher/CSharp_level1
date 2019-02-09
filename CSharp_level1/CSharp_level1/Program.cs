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
        static void Task3()
        {
            /* Переделать программу Пример использования коллекций для решения следующих задач:
             * а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
             * б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
             * в) отсортировать список по возрасту студента;
             * г) *отсортировать список по курсу и возрасту студента; */

            Student.Creator();
            int magistr = 0;
            int[] course = new int[6];
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
            for (int c = 0; c < course.Length; c++) Console.WriteLine($"Курс {c+1} = {course[c]} чел.");

            StudentComparer<Student> cp = new StudentComparer<Student>();
            list.Sort(cp);
            foreach (var v in list) Console.WriteLine($"{v.lastName} {v.firstName} {v.university} {v.faculty} {v.course} {v.department} {v.group} {v.city} {v.age}");
        }

        static void Main(string[] args)
        {
            Task3();

            Console.ReadLine();
        }
    }
}