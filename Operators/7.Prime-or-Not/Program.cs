using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Prime_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
            Console.WriteLine("Insert number: ");
            int number = int.Parse(Console.ReadLine());

            if ((number > 1) && (number <= 100))
            {
                if (number == 2 || number == 3 || number == 5 || number == 7)
                {
                    Console.WriteLine("The number " + number + " is prime");
                }
                else
                {
                    if (number % 2 == 0 || number % 3 == 0 || number % 4 == 0 || number % 5 == 0 || number % 6 == 0 || number % 7 == 0 || number % 8 == 0 || number % 9 == 0 || number % 10 == 0)
                    {

                        Console.WriteLine("The number " + number + " is not prime");
                    }
                    else
                    {
                        Console.WriteLine("The number " + number + " is prime");
                    }
                }

            }
            else
            {
                Console.WriteLine("Number is out of range");
            }


            //Console.Write("Въведи число по-голямо от 3 : ");
            //int number = int.Parse(Console.ReadLine()); // 8
            //int math = (int)Math.Sqrt(number);
            //bool prime = true;
            //for (int i = 2; i <= math; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        Console.WriteLine("NOT a prime number!!!");
            //        prime = false;
            //        break;
            //    }
            //}
            //if (prime == true)
            //{
            //    Console.WriteLine(number + " is prime number");
            //}



        }
    }
}
