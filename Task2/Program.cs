using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            2.Обязательная задача *.Ввести с клавиатуры предложение.Предложение представляет собой слова, 
            разделенные пробелом.Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом 
            без учёта пробелов и регистра(пример палиндрома – «А роза упала на лапу Азора»).
            */
            Console.WriteLine("Введите предложение, состоящее из слов, разделенных пробелами, без знаков препинания.");
            string str = Console.ReadLine().ToLower();

            Boolean flag = true;

            for (int i = 0; i < (str.Length / 2); i++)
            {
                if (str[i]!=str[str.Length-1-i])
                {
                    flag=false  ;
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine("Предложение является палиндромом.");
            }
            else
            {
                Console.WriteLine("Предложение НЕ является палиндромом.");
            }
            
            Console.ReadKey();
        }
    }
}
