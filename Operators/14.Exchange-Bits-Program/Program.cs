using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Exchange_Bits_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // 15. Write a program that exchanges bits {p, p+1, …, p+k-1) 
            //     with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

            while (true)
            {
                Console.Write("Insert number: ");
                long number = long.Parse(Console.ReadLine());

                Console.WriteLine("Insert first position: ");
                int firstPosition = int.Parse(Console.ReadLine());

                Console.WriteLine("Insert second position: ");
                int secondPosition = int.Parse(Console.ReadLine());

                Console.WriteLine("Insert number of positions: ");
                int numberOfPositions = int.Parse(Console.ReadLine());
                numberOfPositions = numberOfPositions + firstPosition;

                Console.WriteLine("Before:" + Convert.ToString(number, 2).PadLeft(32, '0'));

                while (firstPosition < numberOfPositions)
                {
                    long firstMask = 1 << firstPosition;

                    long secondMask = 1 << secondPosition;

                    long bitAtPositionOne = (number & firstMask) > 0 ? 1 : 0;

                    long bitAtPositionTwo = (number & secondMask) > 0 ? 1 : 0;

                    if (bitAtPositionOne != bitAtPositionTwo)
                    {
                        if (bitAtPositionOne == 1)
                        {
                            number = number ^ firstMask;
                        }
                        else if (bitAtPositionOne == 0)
                        {
                            number = number | firstMask;
                        }

                        if (bitAtPositionTwo == 1)
                        {
                            number = number ^ secondMask;
                        }
                        else if (bitAtPositionTwo == 0)
                        {
                            number = number | secondMask;
                        }
                    }

                    // change position += 1
                    firstPosition = firstPosition + 1;
                    secondPosition = secondPosition + 1;
                }

                Console.WriteLine("After :" + Convert.ToString(number, 2).PadLeft(32, '0'));
            }
        }
    }
}
