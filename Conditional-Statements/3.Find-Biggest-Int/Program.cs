using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Find_Biggest_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            //  3. Write a program that finds the biggest
            //     of three integers using nested if statements.

            Console.Write("Insert integer variable 1: ");
            string input1 = Console.ReadLine();
            int value1;
         
            if (int.TryParse(input1, out value1))
            {
                Console.Write("Insert integer variable 2: ");
                string input2 = Console.ReadLine();
                int value2;
               
                if (int.TryParse(input2, out value2))
                {
                    Console.Write("Insert integer variable 3: ");
                    string input3 = Console.ReadLine();
                    int value3;
                    
                    if (int.TryParse(input3, out value3))
                    {
                        if (value1 > value2)
                        {
                            if (value1 > value3)
                            {
                                Console.WriteLine("Biggest is {0}", value1);
                            }
                            else
                            {
                                Console.WriteLine("Biggest is {0}", value3);
                            }
                        }
                        else if (value2 > value3)
                        {
                            Console.WriteLine("Biggest is {0}", value2);
                        }
                        else
                        {
                            Console.WriteLine("Biggest is {0}", value3);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorect value!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Incorect value!!!");
                }
            }
            else
            {
                Console.WriteLine("Incorect value!!!");
            }

        }
    }
}
