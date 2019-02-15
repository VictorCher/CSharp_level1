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
        static Form Form1 = new Form();
        static TextBox tb = new TextBox();
        static NumericUpDown ud = new NumericUpDown();

        static void NumUpDown_Clik(object sender, EventArgs e)
        {
            tb.Text = ud.Value.ToString();
        }

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

        /// <summary>
        /// Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством
        /// Value элемента NumericUpDown
        /// </summary>
        static void Task2()
        {
            Form1.Controls.Add(tb);
            Form1.Controls.Add(ud);
            ud.Top = 20;
            ud.Click += new EventHandler(NumUpDown_Clik);
            Application.Run(Form1);
        }

        public static void Main()
        {
            //Task1();
            Task2();
        }
    }
}
