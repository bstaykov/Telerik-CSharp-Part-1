using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumNumbers
{
    class Program
    {
        /*
           Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insert n:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("n[{0}] = ", i);
                sum += int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("Sum = " + sum);

        }
    }
}
