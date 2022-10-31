using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 3.    Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки. 
             * В строке может быть несколько фрагментов, заключённых в фигурные скобки. 
             * Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.
             */
            Console.WriteLine("Введите строку содержащую фигурные скобки.");
            string s = Console.ReadLine();
            //string s = "один }1 два  2{ три 3{четыре }4 пять шесть семь }5 восемь 8{ девять }9{";

            int i,n,t ;
            i=n=t= 0;

            Boolean flag=false;

            while (i < s.Length)
            {
                if (s[i] == '{' && !flag)
                {
                    flag = true;
                    n++;
                    t = i+1;
                }
                else if(s[i] == '{' && flag)
                {
                    n++;
                }
                else if ( s[i] == '}'&& flag)
                {
                    n--;
                }

                if (n == 0 && flag && (i-t)!=0)
                {
                    flag = false;
                    s=s.Remove(t, i-t);
                    i=t = 0;
                }
                else if(n == 0 && flag && (i - t) == 0)
                {
                    flag = false;
                    t = 0;
                }
                i++;
            }
            Console.WriteLine("Отредактированный текст:\n{0}",s);
            Console.ReadKey();
        }
    }
}
