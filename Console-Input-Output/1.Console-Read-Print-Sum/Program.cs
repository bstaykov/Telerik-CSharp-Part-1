using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Console_Read_Print_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1. Write a program that reads 3 integer 
            //     numbers from the console and prints their sum.



            Console.Write("Insert first integer: ");
            int value1 = int.Parse(Console.ReadLine());

            Console.Write("Insert second integer: ");
            int value2 = int.Parse(Console.ReadLine());

            Console.Write("Insert third integer: ");
            int value3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum = " + (value1 + value2 + value3));
        }
    }
}
