using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Print_Numbers_From_1_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            //8. Write a program that reads an integer number n from the console and prints 
            //   all the numbers in the interval [1..n], each on a single line.

            Console.Write("Insert number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1 ; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
