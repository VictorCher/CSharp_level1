using System;
using System.Collections.Generic;
using System.Text;

static class Message
{
    /// <summary>
    /// Выводит только слова, содержащие ограниченное количество символов
    /// </summary>
    /// <param name="text">Текст для разбора</param>
    /// <param name="n">Максимальное количество символов</param>
    public static void Short(string text, int n)
    {
        text += " ";
        string buff = null;
        foreach (char sym in text.ToCharArray())
        {
            if (Char.IsLetter(sym)) buff += sym;
            else
            {
                if (buff != null && buff.Length <= n) Console.WriteLine(buff);
                buff = null;
            }
        }
    }

    /// <summary>
    /// Удаляет слова, заканчивающиеся на заданный символ
    /// </summary>
    /// <param name="text">Текст для разбора</param>
    /// <param name="n">Символ для поиска</param>
    public static void FilterEnd(string text, char n)
    {
        text = " " + text + " ";
        string buff = null;
        char lastChar = ' ';
        foreach (char sym in text.ToCharArray())
        {
            if (Char.IsLetter(sym)) buff += sym;
            else
            {
                if (buff != null && lastChar != n) Console.Write(buff + sym);
                buff = "";
            }
            lastChar = sym;
        }
    }

    /// <summary>
    /// Находит самое длинное слово
    /// </summary>
    /// <param name="text">Текст для разбора</param>
    public static void Long(string text)
    {
        string maxWord = "";
        text += " ";
        string buff = null;
        foreach (char sym in text.ToCharArray())
        {
            if (Char.IsLetter(sym)) buff += sym;
            else
            {
                if (buff.Length > maxWord.Length) maxWord = buff;
                buff = "";
            }
        }
        Console.WriteLine(maxWord);
    }

    /// <summary>
    /// Находит самые длинные слова
    /// </summary>
    /// <param name="text">Текст для разбора</param>
    public static void Bild(string text)
    {
        StringBuilder result = new StringBuilder();
        string maxWord = "";
        text += " ";
        string buff = null;
        foreach (char sym in text.ToCharArray())
        {
            if (Char.IsLetter(sym)) buff += sym;
            else
            {
                if (buff.Length > maxWord.Length)
                {
                    result.Clear();
                    maxWord = buff;
                    result.Append(buff);
                }
                else if(buff.Length == maxWord.Length) result.Append(" " + buff);
                buff = "";
            }
        }
        Console.WriteLine(result);
    }

    /// <summary>
    /// Анализирует сколько раз повторяется каждое слово
    /// </summary>
    /// <param name="text">Текст для анализа</param>
    public static void Analyz(string text)
    {
        text += " ";
        Dictionary<string, int> result = new Dictionary<string, int>();
        string buff = null;
        foreach (char sym in text.ToCharArray())
        {
            if (Char.IsLetter(sym)) buff += sym;
            else
            {
                if (result.ContainsKey(buff))
                    result[buff]++;
                else result.Add(buff, 1);
                buff = "";
            }
        }
        foreach(string key in result.Keys)
            Console.WriteLine(key + " = " + result[key]);
    }
}