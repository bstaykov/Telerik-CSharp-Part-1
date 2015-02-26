using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Fibonacci_N
{
    class Program
    {
        static void Main(string[] args)
        {
              //7. Write a program that reads a number N and calculates the sum of the first N members
              //   of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
              //   Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
            
            Console.Write("Insert N = ");
            string input = Console.ReadLine();
            int n;

            if (int.TryParse(input, out n))
            {
                if (n > 0)
                {
                    
                    ulong sum = 0;
                    ulong temp = 1;
                    ulong prevTemp = 0;
                    ulong nextTemp;
                    Console.Write(prevTemp);                         
                                                   ///              p  t  n          ............ sum 
                    for (int i = 1; i < n; i++)    ///  n = ! ....  0  1  1  2  3  5  8  13
                    {
                        sum = sum + temp;
                        nextTemp = temp + prevTemp;
                        prevTemp = temp;
                        temp = nextTemp;
                        Console.Write(" : " + prevTemp);
                    }
                    Console.WriteLine("\nSum = " + sum);
                }
                else
                {
                    Console.WriteLine("Insert bigger number!");
                }
            }
            else
            {
                Console.WriteLine("Not a integer!!!");
            }


        }
    }
}
