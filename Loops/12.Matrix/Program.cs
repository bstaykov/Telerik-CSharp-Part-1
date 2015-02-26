using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Write a program that reads from the console a positive
            //      integer number N (N < 20) and outputs a matrix like the following.....
            

            Console.Write("N = ");
            string input = Console.ReadLine();
            int n;

            if (int.TryParse(input, out n) && n < 20 && n > 0)
            {
                Console.WriteLine();
                for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j < n + i; j++)
                    {
                        Console.Write(j + "\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Try again!!!");
            }
        }
    }
}
