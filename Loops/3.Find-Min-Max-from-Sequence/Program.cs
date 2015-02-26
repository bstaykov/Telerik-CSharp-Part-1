using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Find_Min_Max_from_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 03.
             * Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
                 The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
                The output is like in the examples below.
             */
            Console.Write("N = ");
            string input = Console.ReadLine();
            int n;
            int min = int.MaxValue, max = int.MinValue;
            int sum = 0;

            if (int.TryParse(input, out n))
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("Insert input {0}: ", i);
                    string inputs = Console.ReadLine();
                    int nextInput;

                    if (int.TryParse(inputs, out nextInput))
                    {
                        sum += nextInput;
                        if (i == 1)
                        {
                            min = nextInput;
                            max = nextInput;
                        }
                        else
                        {
                            if (max < nextInput)
                            {
                                max = nextInput;
                            }
                            if (min > nextInput)
                            {
                                min = nextInput;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not a integer!!!");
                    }                   
                }
                Console.WriteLine("Min = " + min);
                Console.WriteLine("Max = " + max);
                Console.WriteLine("Sum = " + sum);
                Console.WriteLine("Ave = " + string.Format("{0:0.00}", ((double)sum) / n));
            }
            else
            {
                Console.WriteLine("Not a integer!!!");
            }


        }
    }
}
