using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Print_1_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            //   1. Write a program that prints all the numbers from 1 to N.

            Console.Write("N = ");
            string input = Console.ReadLine();
            int n;

            if (int.TryParse(input, out n))
            {
                for (int i = 1 ; i <= n; i++)
                {
                    Console.Write("{0} ", i);
                }
            }
            else
            {
                Console.WriteLine("Not a integer!!!");
            }
        }
    }
}
