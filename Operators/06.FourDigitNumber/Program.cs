using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigitNumber
{
    class Program
    {
        //    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs           the following:
        //    Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
        //    Prints on the console the number in reversed order: dcba (in our example 1102).
        //    Puts the last digit in the first position: dabc (in our example 1201).
        //    Exchanges the second and the third digits: acbd (in our example 2101).
        static void Main(string[] args)
        {
            int initialNumber = int.Parse(Console.ReadLine());

            int sumOfDigits = 0;
            int firstNumCopy = initialNumber;
            string reverse = string.Empty;
            string lastDigitFirst = string.Empty;
            bool firstLoop = true;

            while (firstNumCopy != 0)
            {
                if(firstLoop)
                {
                    firstLoop = false;
                    int lastDigit = firstNumCopy % 10;
                    lastDigitFirst = lastDigit + (firstNumCopy / 10).ToString();
                }
                int lastNum = firstNumCopy % 10;
                sumOfDigits += lastNum;
                reverse = reverse + lastNum.ToString();
                firstNumCopy = firstNumCopy / 10;
            }

            Console.WriteLine("Sum: " + sumOfDigits);
            Console.WriteLine("Reverse: " + reverse);
            Console.WriteLine("LastDigitFirst: " + lastDigitFirst);

            string num = initialNumber.ToString();
            string first = num[0].ToString();
            string second = num[1].ToString();
            string third = num[2].ToString();
            string forth = num[3].ToString();
            Console.WriteLine("SecondThirdExchanged: {0}{1}{2}{3}", first, third, second, forth);
        }
    }
}
