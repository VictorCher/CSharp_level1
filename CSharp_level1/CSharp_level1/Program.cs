// Чернышов Виктор. Урок 3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    class Complex
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
        public double im;
        public double re;

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }
        public Complex Sub(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im - this.im;
            x3.re = x2.re - this.re;
            return x3;
        }
        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im - this.im;
            x3.re = x2.re - this.re;
            x3.im = this.re * x2.im + this.im * x2.re;
            x3.re = this.re * x2.re - this.im * x2.im;

            return x3;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    class Rational
    {
        int numerator=0;
        int denominator=1;
        string s;
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            this.s =  (numerator + "/" + denominator);
            Console.WriteLine("Вы ввели дробное число: " + s);
        }
        public Rational()
        {
            Console.Write("Результат: ");
        }
        public void Add(Rational value1, Rational value2)
        {
            int denominator;
            int numerator;
            if (value1.denominator != value2.denominator)
            {
                denominator = value1.denominator * value2.denominator;
                numerator = (value1.numerator * value2.denominator) + (value2.numerator * value1.denominator);
            }
            else
            {
                denominator = value1.denominator;
                numerator = value1.numerator + value2.numerator;
            }

            for (int i = (numerator<denominator)? numerator: denominator; i > 1; i--)
            {
                if(numerator%i==0 && denominator % i == 0)
                {
                    numerator /= i;
                    denominator /= i;
                    break;
                }
            }
            if(numerator==denominator) Console.WriteLine(value1.s + " + " + value2.s + " = " + numerator);
            else if (numerator > denominator)
            {
                int integer = numerator / denominator;
                numerator -= integer*denominator;
                if(numerator==0) Console.WriteLine(value1.s + " + " + value2.s + " = " + integer);
                else Console.WriteLine(value1.s + " + " + value2.s + " = " + integer + " " + numerator + '/' + denominator);
            }
            else Console.WriteLine(value1.s + " + " + value2.s + " = " + numerator + '/' + denominator);
        }
    }
    class Program
    {
        struct Complex
        {
            public double im;
            public double re;
            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }
            public Complex Sub(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }
            public Complex Multi(Complex x)
            {
                Complex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }
            public string ToString()
            {
                return re + "+" + im + "i";
            }
        }

        static void Task1()
        {
            /* а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
             * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
             * в) Добавить диалог с использованием switch демонстрирующий работу класса. */
            Console.WriteLine("Работа структуры");
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;
            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;
            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Sub(complex2);
            Console.WriteLine(result.ToString());

            Console.WriteLine("Работа класса\nВведите 1 - для того, чтобы получить сумму двух чисел\nВведите 2 - для того, чтобы получить произведение двух чисел\nВведите 3 - для того, чтобы получить разность двух чисел\n");
            Complex complex12 = new Complex();
            complex12.re = 1;
            complex12.im = 1;

            Complex complex22 = new Complex();
            complex22.re = 2;
            complex22.im = 2;

            Complex result2;
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    result2 = complex12.Plus(complex22);
                    Console.WriteLine(result2.ToString());
                    break;
                case 2:
                    result2 = complex12.Multi(complex22);
                    Console.WriteLine(result2.ToString());
                    break;
                case 3:
                    result2 = complex12.Sub(complex22);
                    Console.WriteLine(result2.ToString());
                    break;
            }
        }
        static void Task2()
        {
            /* а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
             * Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму
             * вывести на экран, используя tryParse. */

            int sum = 0;
            while(true)
            {
                int n;
                Console.Write("Введите число: ");
                bool flag = int.TryParse(Console.ReadLine(), out n);
                if(flag == true)
                {
                    if (n == 0) break;
                    else if (n % 2 != 0 && n > 0) sum+=n;
                }
                else Console.WriteLine("Некорректное значение!");
            }
            Console.WriteLine("Сумма чисел равна: " + sum);
        }
        static void Task3()
        {
            Console.Write("Введите числитель: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель: ");
            int y1 = int.Parse(Console.ReadLine());
            Rational a = new Rational(x1,y1);

            Console.Write("Введите числитель: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель: ");
            int y2 = int.Parse(Console.ReadLine());
            Rational b = new Rational(x2, y2);

            Rational summ = new Rational();
            summ.Add(a, b);
        }
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            Task3();

            Console.ReadLine();
        }
    }
}
