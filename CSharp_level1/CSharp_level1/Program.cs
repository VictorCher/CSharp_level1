// Чернышов Виктор. Урок 8
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_level1
{
    class Program
    {
        /// <summary>
        /// C помощью рефлексии выводит все свойства структуры DateTime
        /// </summary>
        static void Task1()
        {
            DateTime dt = new DateTime();
            object[] t = dt.GetType().GetProperties();
            string result = "";
            foreach (object a in t) result += a.ToString() + "\n";
            MessageBox.Show(result, "Свойства структуры DataTime");
        }

        public static void Main()
        {
            Task1();

        }
    }
}
