using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Odd_Or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Write an expression that checks if given integer is odd or even.

            while (true)
            {
                Console.WriteLine("Insert integer value: ");
                int value = int.Parse(Console.ReadLine());

                if (value % 2 == 0)
                {
                    Console.WriteLine(value + " is EVEN");
                }
                else
                {
                    Console.WriteLine(value + " is ODD");
                }
            }

            //int[] masiv = { 3, 4, 5, 6, 234, 55443 };
            //for (int i = 0; i < masiv.Length; i++)
            //{
            //    if (masiv[i] % 2 == 0)
            //    {
            //        Console.WriteLine(masiv[i] + " is EVEN");
            //    }
            //    else
            //  s  {
            //        Console.WriteLine(masiv[i] + " is ODD");
            //    }
            //}
        }
    }
}
