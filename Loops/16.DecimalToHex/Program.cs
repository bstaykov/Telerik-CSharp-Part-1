using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DecimalToHex
{
    /*
     * Using loops write a program that converts an integer number to its hexadecimal representation.
     * The input is entered as long. The output should be a variable of type string.
     * Do not use the built-in .NET functionality.
     */

    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            string output = string.Empty;
            int tempSum = 0;
            long one = 1;

            for (int i = 0, counter = 0; i < 64; i++, counter++)
            {
                long mask = one << i;
                long biteValue = input & mask;
                if (biteValue != 0)
                {
                    tempSum += PowerOfTwo(counter);
                }

                if (counter == 3)
                {
                    output = NumberToHex(tempSum) + output;
                    counter = -1;
                    tempSum = 0;
                }
            }

            Console.WriteLine(output.TrimStart('0'));
        }

        private static int PowerOfTwo(int power)
        {
            int result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= 2;
            }

            return result;
        }

        private static string NumberToHex(int number)
        {
            string result = string.Empty;
            switch (number)
            {
                case 0: result = "0";
                    break;
                case 1: result = "1";
                    break;
                case 2: result = "2";
                    break;
                case 3: result = "3";
                    break;
                case 4: result = "4";
                    break;
                case 5: result = "5";
                    break;
                case 6: result = "6";
                    break;
                case 7: result = "7";
                    break;
                case 8: result = "8";
                    break;
                case 9: result = "9";
                    break;
                case 10: result = "A";
                    break;
                case 11: result = "B";
                    break;
                case 12: result = "C";
                    break;
                case 13: result = "D";
                    break;
                case 14: result = "E";
                    break;
                case 15: result = "F";
                    break;
                default: throw new IndexOutOfRangeException("Invalid calculations!");
            }

            return result;
        }
    }
}
