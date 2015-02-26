using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Exchange_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            // 13. Write a program that exchanges bits 3, 4 and 5 
            //     with bits 24, 25 and 26 of given 32-bit unsigned integer.

            //Console.WriteLine(UInt32.MaxValue);

            Console.Write("Insert number: ");
            long number = long.Parse(Console.ReadLine());

            int firstPosition = 3;

            int secondPosition = 24;

            while (firstPosition < 6 )
            {
                int firstMask = 1 << firstPosition;

                int secondMask = 1 << secondPosition;

                int b1 = (number & firstMask) > 0 ? 1 : 0;

                int b2 = (number & secondMask) > 0 ? 1 : 0;

                if (b1 != b2)
                {
                    if (b1 == 1)
                    {
                        number = number ^ firstMask; 
                    }
                    else if (b1 == 0)
                    {
                        number = number | firstMask;
                    }

                    if (b2 == 1)
                    {
                        number = number ^ secondMask;
                    }
                    else if (b2 == 0)
                    {
                        number = number | secondMask;
                    }
                }

                firstPosition = firstPosition + 1;
                secondPosition = secondPosition + 1;
            }

            Console.WriteLine(number);
            
        }
    }
}
