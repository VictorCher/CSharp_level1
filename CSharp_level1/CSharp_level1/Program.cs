// Чернышов Виктор. Урок 1
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
            /* Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
             * В результате вся информация выводится в одну строчку:
             * а) используя  склеивание;
             * б) используя форматированный вывод;
             * в) используя вывод со знаком $. */

            Console.WriteLine("Анкета");
            Console.Write("Введите Ваше имя: ");
            string first_name = Console.ReadLine();
            Console.Write("Введите Вашу фамилию: ");
            string last_name = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
            string age = Console.ReadLine();
            Console.Write("Введите Ваш рост: ");
            string height = Console.ReadLine();
            Console.Write("Введите Ваш вес: ");
            string weight = Console.ReadLine();
            Console.WriteLine("Ваше имя - " + first_name + ", фамилия - " + last_name + ", возраст - " + age + ", рост - " + height + ", вес - " + weight);
            Console.WriteLine("Ваше имя - {0}, фамилия - {1}, возраст - {2}, рост - {3}, вес - {4}", first_name, last_name, age, height, weight);
            Console.WriteLine($"Ваше имя - {first_name}, фамилия - {last_name}, возраст - {age}, рост - {height}, вес - {weight}");
        }
        static void Task2()
        {
            /* Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле k=m/(h*h); 
             * где m — масса тела в килограммах, h — рост в метрах. */
            Console.Write("Введите массу тела в килограммах: ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Введите рост в метрах: ");
            float height = float.Parse(Console.ReadLine());
            float k = weight / (height * height);
            Console.WriteLine($"Индекс массы тела составляет: {k:N}");
        }
        static double Task3(int x1, int y1, int x2, int y2)
        {
            /* Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле 
             * r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)).Вывести результат, используя спецификатор формата .2f
             * (с двумя знаками после запятой). Выполнить задание, оформив вычисления расстояния между точками в виде метода. */
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Task4(ref int a, ref int b)
        {
            /* Написать программу обмена значениями двух переменных:
             * а) с использованием третьей переменной;
             * б) без использования третьей переменной. */
            int buf = a;
            a = b;
            b = buf;
            /*
            a ^= b;
            b ^= a;
            a ^= b;
            */
        }
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            /*
            Console.Write("Введите координату Х для первой точки: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату Y для первой точки: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату Х для первой точки: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату Y для первой точки: ");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Расстояние между точками равно: {0:n2}", Task3(x1, y1, x2, y2));
            */

            int a = 2;
            int b = 3;
            Task4(ref a, ref b);
            Console.WriteLine(a + ", " + b);

            Console.ReadLine();
        }
    }
}
