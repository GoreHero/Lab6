using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Tesk1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string resultString = "";
            foreach(string s in stringArray)
            {
                resultString += s.Substring(0, 1).ToUpper() + s.Substring(1) + ' f';
            }*/

            string resultString = String.Format("{0:#(###)###-##-##}", 89017949428);
            Console.WriteLine(resultString);
            Console.ReadKey();
        }
    }
}
