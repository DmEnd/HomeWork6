using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.    Обязательная задача*. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
             * Знаки препинания не используются. Найти самое длинное слово в строке.
             */
            //string str = "ff fff f";

            Console.WriteLine("Введите предложение, состоящее из слов, разделенных пробелами, без знаков препинания.");
            string str = Console.ReadLine();
            string[] ArrayStr = str.Split();

            int max = ArrayStr[0].Length;
            str = ArrayStr[0];

            foreach (string s in ArrayStr)
            {
                if (max < s.Length)
                {
                    max = s.Length;
                    str = s;
                }
            }

            Console.WriteLine("Cамое длинное слово в предложении \"{0}\"", str);
            Console.ReadKey();
        }
    }
}
