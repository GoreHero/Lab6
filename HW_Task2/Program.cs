using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = string.Join("",Console.ReadLine().ToLower().Split(' '));
            //string[] array = Console.ReadLine().ToLower().Split(' ');
            //string str = string.Join("",array);
            string str2 = "";
            foreach (char c in str)
            {
                str2 = c + str2;

            }
            if (str == str2)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.ReadKey();
        }
    }
}
