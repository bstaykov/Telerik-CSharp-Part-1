using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DividorsFive
{
    /*
     * Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
     * such that the reminder of the division by 5 is 0.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = firstNum + 1; i < secondNum; i++)
            {
                if (i % 5 == 0)
                {
                    sum += 1;
                }
            }

            Console.WriteLine("Numbers whitch division by 5 is 0 = " + sum);
        }
    }
}
