using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FormatingNumbers
{
    class Program
    {
        /*
            Write a program that reads 3 numbers:
            integer a (0 <= a <= 500)
            floating-point b
            floating-point c
            The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
            The number a should be printed in hexadecimal, left aligned
            Then the number a should be printed in binary form, padded with zeroes
            The number b should be printed with 2 digits after the decimal point, right aligned
            The number c should be printed with 3 digits after the decimal point, left aligned.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insert first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert second number: ");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Insert third number: ");
            float thirdNumber = float.Parse(Console.ReadLine());

            string hexA = Convert.ToString(firstNumber, 16);

            string binaryA = Convert.ToString(firstNumber, 2);
            string binaryPaddedA = binaryA.PadLeft(10, '0');

            Console.WriteLine("|{0, -10}|{1, 10}|{2,10:0.00}|{3,-10:0.000}|", hexA, binaryPaddedA, secondNumber, thirdNumber);
        }
    }
}
