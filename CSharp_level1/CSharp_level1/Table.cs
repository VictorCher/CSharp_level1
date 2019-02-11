using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    public delegate double Fun(double a, double x);
    class Table
    {
        public static void PrintTable(Fun f, double a, double x, double b)
        {
            Console.WriteLine("----- A ----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,7:0.000} | {1,7:0.000} | {2,7:0.000} |", a, x, f(a, x));
                x += 1;
            }
            Console.WriteLine("-----------------------------");
        }
    }
}
