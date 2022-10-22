using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task3
{
    internal class Program
    {
        //Дана строка S.Из строки требуется удалить текст, заключенный в фигурные скобки.
        //В строке может быть несколько фрагментов, заключённых в фигурные скобки.
        //Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.
        static void Main(string[] args)
        {
            Console.WriteLine("прим. вложенные фигурные скобки должны быть закрыты");
            Console.WriteLine("Ввод: ");
            string s = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{')
                {
                    for (int j = i+1; j < s.Length; j++)
                    {
                        if (s[j]=='{')
                        {
                            count+=1;
                            continue;
                        }
                        if ((s[j]=='}')&& (count>0))
                        {
                            count-=1;
                            continue;
                        }
                        if ((s[j] == '}')&&(count == 0 ))
                        {
                            
                            s = s.Substring(0, i) + s.Substring(j + 1);
                            break;
                        }
                    }                        
                }
            }
            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
