using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Greatest_Common_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that calculates the greatest common divisor (GCD)
            //    of given two numbers. Use the Euclidean algorithm (find it in Internet).



            Console.Write("Insert X = ");
            string input1 = Console.ReadLine();
            int x;

            if (int.TryParse(input1, out x))
            {
                Console.Write("Insert Y = ");
                string input2 = Console.ReadLine();
                int y;
                int GCD = 1;
                int firstNumber;
                int secondNumber;

                if (int.TryParse(input2, out y))
                {
                    firstNumber = x > y ? x : y;
                    secondNumber = x > y ? y : x;

                    while (secondNumber != 0)
                    {
                        GCD = firstNumber % secondNumber;
                        
                        if (GCD == 0)
                        {
                            GCD = secondNumber;
                            break;
                        }
                        else
                        {
                            firstNumber = secondNumber;
                            secondNumber = GCD;
                        }
                    }
                    Console.WriteLine("Greatest common divisor (GCD) = " + GCD);
                }
                else
                {
                    Console.WriteLine("Y is not a integer!");
                }
            }
            else
            {
                Console.WriteLine("X is not a integer!");
            }
        }
    }
}
