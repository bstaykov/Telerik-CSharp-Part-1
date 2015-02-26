using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 101, c = 1001;

            Console.Write(a + Environment.NewLine + b + Environment.NewLine + c + Environment.NewLine);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            string numbersInString = "1, 101, 1001";
            Console.WriteLine(numbersInString.Replace(", ", Environment.NewLine));
        }
    }
}
