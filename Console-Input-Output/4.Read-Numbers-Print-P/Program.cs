using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Read_Numbers_Print_P
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Write a program that reads two positive integer numbers and prints 
            //how many numbers p exist between them such that the reminder of the 
            //division by 5 is 0 (inclusive). Example: p(17,25) = 2.


            Console.WriteLine("Insert number 1: ");
            int numberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert number 2: ");
            int numberTwo = int.Parse(Console.ReadLine());
            int small;
            int big;

            if (numberOne != numberTwo)
            {
                small = numberOne < numberTwo ? numberOne : numberTwo;
                big = numberOne > numberTwo ? numberOne : numberTwo;
            }
            else
            {
                small = big = numberOne;
            }

            int difference = big - small;
            int result = 0;

            Console.WriteLine("Big = " + big);
            Console.WriteLine("Small = " + small);

            if (small % 5 == 0)
            {
                result = result + 1;
            }
            result = result + (difference + (small % 5)) / 5;

            Console.WriteLine("Result = " + result);

        }
    }
}
