using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Third_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Write an expression that checks for given integer 
            // if its third digit (right-to-left) is 7. E. g. 1732  true.

            Console.Write("Insert number: ");
            int x = int.Parse(Console.ReadLine());
            x = Math.Abs(x);
            //Console.WriteLine(x);

            x = x % 1000;
            //Console.WriteLine(x);
            x = x / 100;

            if (x == 7)
            {
                Console.WriteLine("third digit is: " + x);
            }
            else
            {
                Console.WriteLine("Third digit is not 7!");
            }

        }
    }
}
