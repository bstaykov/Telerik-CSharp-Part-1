using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddEvenProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            /*You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

            Console.WriteLine("Insert numbers separated by space: ");
            string input = Console.ReadLine();
            string[] separators = { " " };

            string[] stringNumbers = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[stringNumbers.Length];
            int oddProduct = 1;
            int evenProduct = 1;


            for (int i = 0; i < stringNumbers.Length; i++)
            {
                int currentNumber = int.Parse(stringNumbers[i]);
                if (i % 2 == 0)
                {
                    oddProduct = oddProduct * currentNumber;
                }
                else
                {
                    evenProduct = evenProduct * currentNumber;
                }
            }

            if (oddProduct == evenProduct)
            {
                Console.WriteLine("YES: " + oddProduct);
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
