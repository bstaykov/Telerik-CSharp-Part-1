using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DecimalToBinary
{
    /*
     * Using loops write a program that converts an integer number to its binary representation.
     * The input is entered as long. The output should be a variable of type string.
     * Do not use the built-in .NET functionality.
     */

    class Program
    {
        private static string baseString = "";

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < 16; i++)
            {
                int mask = 1 << i;
                int positionIndex = input & mask;
                if (positionIndex != 0)
                {
                    baseString = "1" + baseString;
                }
                else
                {
                    baseString = "0" + baseString;
                }
            }

            Console.WriteLine(baseString);
        }
    }
}
