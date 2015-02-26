using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Subset
{
    class Program
    {
        static void Main(string[] args)
        {
            //   9. We are given 5 integer numbers. 
            //      Write a program that checks if the sum of some 
            //      subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.

            Console.Write("Input the wanted sum: ");
            long wantedSum = long.Parse(Console.ReadLine());

            Console.Write("Number of elements: ");
            long length = long.Parse(Console.ReadLine());

            long[] numbers = new long[length];
            int counter = 0;
            string subset;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("\nEnter element {0} = ", i + 1);
                numbers[i] = long.Parse(Console.ReadLine());
            }

            int numberOfCombinations = (int)Math.Pow(2, length);

            for (int i = 1; i < numberOfCombinations; i++)
            {
                subset = string.Empty;
                long sum = 0;
                for (int j = 0; j <= length; j++)
                {
                    int mask = 1 << j;
                    int coincidence = i & mask;

                    if (coincidence != 0)
                    {
                        sum = sum + numbers[j];
                        subset = subset + " " + numbers[j];
                    }
                }
                if (sum == wantedSum)
                {
                    counter++;
                    Console.WriteLine("\nSubset: " + subset);
                }
            }
            Console.WriteLine("\nNumber of subsets that have 'sum = 0' is: {0}\n", counter);
           

        }
    }
}
