using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    class Message
    {
        public static void Short(string text, int n)
        {
            string buff = null;
            foreach (char sym in text.ToCharArray())
            {
                if (Char.IsLetter(sym) && sym != ' ') buff += sym;
                else
                {
                    if (buff != null && buff.Length <= n) Console.WriteLine(buff);
                    buff = "";
                }

            }

        }
        static void Limit(string text, int n)
        {

        }
        static void Long(string text, int n)
        {

        }
        static void Bild(string text, int n)
        {

        }
    }
}
