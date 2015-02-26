using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            //   6. Write a program that enters the coefficients a, b and c of a quadratic equation
            //      a*x2 + b*x + c = 0
            //      and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
            Console.WriteLine("Task: Find the roots of a*x2 + b*x + c = 0\n");
            Console.Write("Insert variable 'a': ");
            string input1 = Console.ReadLine();
            double value1;

            if (double.TryParse(input1, out value1))
            {
                Console.Write("Insert variable 'b': ");
                string input2 = Console.ReadLine();
                double value2;

                if (double.TryParse(input2, out value2))
                {
                    Console.Write("Insert variable 'c': ");
                    string input3 = Console.ReadLine();
                    double value3;

                    if (double.TryParse(input3, out value3))
                    {
                        Console.WriteLine("\n{0}x2 + {1}x + {2} = 0\n", value1, value2, value3);

                        if (value1 == 0)
                        {
                            Console.WriteLine("x = " + ((double)-value3 / value2));
                        }
                        else
                        {
                            double discriminant = value2 * value2 - 4 * value1 * value3;
                            
                            if (discriminant < 0)
                            {
                                Console.WriteLine("The quadratic equation has no real roots!!!");
                            }
                            else if (discriminant == 0)
                            {
                                Console.WriteLine("There is exactly one real root x = " + (-value2 / (2 * value1)));
                            }
                            else
                            {
                                Console.WriteLine("x1 = {0}, x2 = {1}", (-value2 + Math.Sqrt(discriminant)) / (2 * value1), (-value2 - Math.Sqrt(discriminant)) / (2 * value1));
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
