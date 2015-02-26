using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Print_Bigger_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Write a program that gets two numbers from the console
            //    and prints the greater of them. Don’t use if statements.


            Console.WriteLine("Insert number 1: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert number 2: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The bigger number is : " + (firstNumber > secondNumber ? firstNumber : secondNumber));

            Console.WriteLine("Math.Max({0}, {1}) = {2}", firstNumber, secondNumber, Math.Max(firstNumber, secondNumber));
        }
    }
}
