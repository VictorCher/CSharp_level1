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

        static void Main(string[] args)
        {
            Task1();

            Console.ReadLine();
        }
    }
}
