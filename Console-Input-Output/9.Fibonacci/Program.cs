using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

            Console.WriteLine("Insert n = ");
            int n = int.Parse(Console.ReadLine());

            double firstNumber = 0;
            double secondNumber = 1;

            if (n == 0)
            {
                return;
            }

            Console.Write(firstNumber + ", ");

            if (n == 1)
            {
                return;
            }

            Console.Write(secondNumber + ", ");

            double sum = 1;

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(sum + ", ");
                firstNumber = secondNumber;
                secondNumber = sum;
                sum = firstNumber + secondNumber;
            }
        }
    }
}
