using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Show_Sign
{
    class Program
    {
        static void Main(string[] args)
        {

            //  2. Write a program that shows the sign (+ or -)
            //     of the product of three real numbers without calculating it. 
            //     Use a sequence of if statements.

            Console.Write("Insert integer variable 1: ");
            string input1 = Console.ReadLine();
            int value1;
            System.Threading.Thread.Sleep((int)1000);

            if (int.TryParse(input1, out value1))
            {
                Console.Write("Insert integer variable 2: ");
                string input2 = Console.ReadLine();
                int value2;
                System.Threading.Thread.Sleep((int)1000);

                if (int.TryParse(input2, out value2))
                {
                    Console.Write("Insert integer variable 3: ");
                    string input3 = Console.ReadLine();
                    int value3;
                    System.Threading.Thread.Sleep((int)1000);

                    if (int.TryParse(input3, out value3))
                    {
                        Console.WriteLine("");
                        if (value1 == 0 || value2 == 0 || value3 == 0)
                        {
                            Console.WriteLine("Product = 0");
                        }
                        else
                        {
                            int count = 0;
                            if (value1 > 0)
                            {
                                count = count + 1;
                            }
                            if (value2 > 0)
                            {
                                count = count + 1;
                            }
                            if (value3 > 0)
                            {
                                count = count + 1;
                            }
                            if (count % 2 == 1)
                            {
                                Console.WriteLine("Product is positive.");
                            }
                            else if (count % 2 == 0)
                            {
                                Console.WriteLine("Product is negative.");
                            }
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
