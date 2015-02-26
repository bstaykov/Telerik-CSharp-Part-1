using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Print_Not_Divisible_By
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Write a program that prints all the numbers 
            //    from 1 to N, that are not divisible by 3 and 7 at the same time.

            Console.Write("N = ");
            string input = Console.ReadLine();
            int n;

            if (int.TryParse(input, out n))
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 7 != 0 || i % 3 != 0) // (!(i % 7 == 0 && i % 3 == 0))
                    {
                        Console.Write("{0} ",i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Not a integer!!!");
            }

        }
    }
}
