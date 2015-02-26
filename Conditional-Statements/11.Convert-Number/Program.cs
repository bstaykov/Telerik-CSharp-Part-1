using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Number
{
    class Program
    {

        static void Main(string[] args)
        {
            // 11. * Write a program that converts a number in the range [0...999]
            //       to a text corresponding to its English pronunciation.

            string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred" };
            while (true)
            {
                Console.WriteLine("Insert number: ");
                string input = Console.ReadLine();
                ushort number;
                bool isNumber = ushort.TryParse(input, out number);

                if (isNumber && number >= 0 && number < 1000)
                {
                    int hundreds = number / 100;
                    int secondNumber = (number % 100) / 10;


                    int tens = number % 100; // 0..99
                    int thirdNumber = tens % 10;

                    if (hundreds != 0) // [100, 999]
                    {
                        Console.Write(arr[hundreds] + " " + arr[arr.Length - 1]); // 100, 200...900

                        if (tens != 0)
                        {
                            if (tens < 10)
                            {
                                Console.Write(" and " + arr[tens]);
                            }
                            else
                            {
                                if (tens >= 20)
                                {
                                    Console.Write(" " + arr[18 + secondNumber]);  // 20 30 40 .... 90
                                    if (thirdNumber != 0) // 21..29 31..39 ...
                                    {
                                        Console.Write(" " + arr[thirdNumber]); // 1 2 3 4 .... 9
                                    }
                                }
                                else
                                {
                                    Console.Write(" and " + arr[tens]); // 1 2 3 4 ...... 19
                                }
                            }
                        }

                    }
                    else if (tens < 10) // 1..9 
                    {
                        Console.Write(arr[thirdNumber]);
                    }
                    else
                    {

                        if (tens > 20) // 21..29 31..39 ..
                        {
                            Console.Write(arr[18 + secondNumber]);  // 20..30....90
                            if (thirdNumber != 0) // 1..9
                            {
                                Console.Write(" " + arr[thirdNumber]);
                            }
                        }
                        else
                        {
                            Console.Write(arr[tens]);
                        }
                    }
                }
                else
                {
                    Console.Write("0 < x > 999 or not a integer!!!");
                }
                Console.WriteLine();
            }
        }
    }
}
