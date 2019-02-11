using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CSharp_level1
{
    public delegate double F(double x);
    class FuncMin
    {
        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double F2(double x)
        {
            return 2 * x;
        }
        public static double F3(double x)
        {
            return x * x;
        }
        public static double F4(double x)
        {
            return x + 5;
        }

        public static void SaveFunc(string fileName, F mes, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create,
            FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(mes(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }

        public static void Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                Console.WriteLine(d);
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
        }


    }
}
