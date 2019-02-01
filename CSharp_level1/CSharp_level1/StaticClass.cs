using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    static class StaticClass
    {
        public static string MasPath = "Myas.txt";
        public static int sizeMas = 20;

        /// <summary>
        /// Создает файл массива из элементов со случайными числами от -10000 до 10000
        /// </summary>
        public static void GenMas()
        {
            Random rnd = new Random();
            StreamWriter file = new StreamWriter(MasPath);
            for (int i = 0; i < sizeMas; i++)
                file.WriteLine(rnd.Next(-10000, 10000));
            file.Close();
        }

        /// <summary>
        /// Считывает массив из текстового файла
        /// </summary>
        /// <returns></returns>
        public static int[] ReadMas()
        {
            int[] mas = new int[sizeMas];
            try
            {
                StreamReader file = new StreamReader(MasPath);
                for (int i = 0; i < sizeMas; i++)
                    mas[i] = int.Parse(file.ReadLine());
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            return mas;
        }

        /// <summary>
        /// Находит и выводит количество пар элементов массива, в которых только одно число делится на 3
        /// </summary>
        /// <param name="mas"></param>
        static void Pair(int[] mas)
        {
            int count = 0;
            for(int i = 0; i < sizeMas - 1; i++)
            {
                if (mas[i] % 3 == 0 && mas[i + 1] % 3 != 0) count++;
            }
            Console.WriteLine("Количество пар: " + count);
        }
    }
}
