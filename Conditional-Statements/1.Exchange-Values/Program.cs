using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Exchange_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Write an if statement that examines two integer 
            //    variables and exchanges their values if 
            //    the first one is greater than the second one.

            Console.Write("Insert integer variable 1: ");
            string input1 = Console.ReadLine();
            int value1;

            if (int.TryParse(input1, out value1))
            {
                Console.WriteLine("Valid number. Value 1 =  {0}\n", value1);

                Console.Write("Insert integer variable 2 (greater than value 1): ");
                string input2 = Console.ReadLine();
                int value2;

                if (int.TryParse(input2, out value2))
                {
                    Console.WriteLine("Valid number. Value 2 = {0}\n", value2);
                   
                    if (value1 > value2)
                    {
                        int temp = value1;
                        value1 = value2;
                        value2 = temp;
                        Console.WriteLine("Values exchanged.");
                    }
                    Console.WriteLine("Value 1 = {0}\nValue 2 = {1}\n\n", value1, value2);
                }
                else
                {
                    Console.WriteLine("Invalid number {0}", input2);
                }
            }
            else
            {
                Console.WriteLine("Invalid number {0}\n", input1);
            }

            
        }
    }
}
