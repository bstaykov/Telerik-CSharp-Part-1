using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //  4. Sort 3 real values in descending order using nested if statements.

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

                                if (value3 > value2)
                                {
                                    Console.WriteLine("{0}, {1}, {2}", value1, value3, value2);
                                }
                                else
                                {
                                    Console.WriteLine("{0}, {1}, {2}", value1, value2, value3);
                                }

                            }
                            else
                            {
                                Console.WriteLine("{0}, {1}, {2}", value3, value1, value2);
                            }

                        }
                        else if (value2 > value3)
                        {
                            if (value3 > value1)
                            {
                                Console.WriteLine("{0}, {1}, {2}", value2, value3, value1);
                            }
                            else
                            {
                                Console.WriteLine("{0}, {1}, {2}", value2, value1, value3);
                            }
                        }
                        else
                        {
                            Console.WriteLine("{0}, {1}, {2}", value3, value2, value1);
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
