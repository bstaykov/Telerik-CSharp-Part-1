using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Get_Numbers_Print_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert some numbers separated by empty space: ");

            string input = Console.ReadLine();

            char [] separators = {' '};
            string[] separatedNumbers = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            float sum = 0;
            for (int i = 0; i < separatedNumbers.Length; i++)
			{
			    sum += float.Parse(separatedNumbers[i]);
			}

            Console.WriteLine("Sum: " + sum);


            //// 7. Write a program that gets a number n 
            ////    and after that gets more n numbers and calculates and prints their sum. 


            //Console.WriteLine("Insert number: ");
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Insert number {0}: ", i);
            //    sum = sum + int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Sum = " + sum);
        }
    }
}
