using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class IntroToCSharp
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello!!!");

            DateTime date = DateTime.Now;

            System.Console.WriteLine(date);

            string  a = "1, 101, 1001";
            Console.WriteLine(a.Replace(", ", Environment.NewLine));

            int b = 2, c = 3, d = 4;

            string newLine = Environment.NewLine + Environment.NewLine;

            Console.WriteLine(b + newLine + c + newLine + d + newLine + Math.Sqrt(625));

            int a1 = 2, b1 = -3;
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i + " : " + a1 + newLine + ++i + " : "+ b1 + newLine);

                a1 += 2;
                b1 -= 2; 
            }
            Console.Write("Въведете вашата възраст: ");
            string age = Console.ReadLine();
            int myAge = Convert.ToInt16(age) + 10;
            Console.WriteLine("След 10 години ще бъдете на " + myAge + " години!!!");

            int myAge2 = int.Parse(age) + 10;
            Console.WriteLine("След 10 години ще бъдете на " + myAge2 + " години!!!");
            
            
        }
    }
}
