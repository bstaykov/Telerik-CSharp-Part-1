using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexToDecimal
{
    class Program
    {
        /*
         * Using loops write a program that converts a hexadecimal integer number to its decimal form.
         * The input is entered as string. The output should be a variable of type long.
         * Do not use the built-in .NET functionality.
         */

        static void Main(string[] args)
        {
            Console.Write("HEX = ");
            string input = Console.ReadLine();
            long sum = 0;
            int counter = 0;

            for (int possition = input.Length - 1; possition >=0; possition--)
            {
                int current = HexToDecimal(input[possition].ToString());
                sum += current * PowerOfSixteen(counter);
                counter++;
            }

            Console.WriteLine(sum);
        }

        private static int HexToDecimal(string hex)
        {
            int result = 0;
            switch (hex)
            {
                case "0": result = 0;
                    break;
                case "1": result = 1;
                    break;
                case "2": result = 2;
                    break;
                case "3": result = 3;
                    break;
                case "4": result = 4;
                    break;
                case "5": result = 5;
                    break;
                case "6": result = 6;
                    break;
                case "7": result = 7;
                    break;
                case "8": result = 8;
                    break;
                case "9": result = 9;
                    break;
                case "A": result = 10;
                    break;
                case "B": result = 11;
                    break;
                case "C": result = 12;
                    break;
                case "D": result = 13;
                    break;
                case "E": result = 14;
                    break;
                case "F": result = 15;
                    break;
                default: throw new FormatException("Invalid input");
            }
            return result;
        }

        private static long PowerOfSixteen(int power)
        {
            long result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= 16;
            }

            return result;
        }
    }
}
