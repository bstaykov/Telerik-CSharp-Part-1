using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinaryToLong
{
    /*  Using loops write a program that converts a binary integer number to its decimal form.
            The input is entered as string. The output should be a variable of type long.
            Do not use the built-in .NET functionality.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary number");
            string input = Console.ReadLine();
            long sum = 0;
            int counter = 0;

            for (int len = input.Length - 1; len >= 0; len--)
            {
                int current = int.Parse(input[len].ToString());

                if (current == 1)
                {
                    sum += PowerOfTwo(counter);
                }
                counter++;
            }

            Console.WriteLine(sum);
        }

        private static long PowerOfTwo(int power)
        {
            return 1 << power;
        }
    }
}
