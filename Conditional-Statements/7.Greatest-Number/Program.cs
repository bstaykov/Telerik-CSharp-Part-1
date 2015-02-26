using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Greatest_Number
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
                Write a program that finds the biggest of five numbers by using only four(4) if statements.
             */
            Console.WriteLine("Insert value 1: ");
            int MAX= int.Parse(Console.ReadLine());

            Console.WriteLine("Insert value 2: ");
            int value2 = int.Parse(Console.ReadLine());
            if(value2 > MAX)
            {
                MAX = value2;
            }

            Console.WriteLine("Insert value 3: ");
            int value3 = int.Parse(Console.ReadLine());
            if (value3 > MAX)
            {
                MAX = value3;
            }

            Console.WriteLine("Insert value 4: ");
            int value4 = int.Parse(Console.ReadLine());
            if (value4 > MAX)
            {
                MAX = value4;
            }

            Console.WriteLine("Insert value 5: ");
            int value5 = int.Parse(Console.ReadLine());
            if (value5 > MAX)
            {
                MAX = value5;
            }

            Console.WriteLine("Max = {0}", MAX);

            ////  7. Write a program that finds the greatest of given 5 variables.

            //Console.Write("Insert integer variable 1: ");
            //string input1 = Console.ReadLine();
            //int value1;

            //if (int.TryParse(input1, out value1))
            //{
            //    Console.Write("Insert integer variable 2: ");
            //    string input2 = Console.ReadLine();
            //    int value2;
            //    int maxValue = value1;

            //    if (int.TryParse(input2, out value2))
            //    {
            //        Console.Write("Insert integer variable 3: ");
            //        if (value2 > maxValue)
            //        {
            //            maxValue = value2;
            //        }
            //        string input3 = Console.ReadLine();
            //        int value3;

            //        if (int.TryParse(input3, out value3))
            //        {
            //            Console.Write("Insert integer variable 3: ");
            //            if (value3 > maxValue)
            //            {
            //                maxValue = value3;
            //            }
            //            string input4 = Console.ReadLine();
            //            int value4;

            //            if (int.TryParse(input4, out value4))
            //            {
            //                Console.Write("Insert integer variable 3: ");
            //                if (value4 > maxValue)
            //                {
            //                    maxValue = value4;
            //                }
            //                string input5 = Console.ReadLine();
            //                int value5;

            //                if (int.TryParse(input5, out value5))
            //                {
            //                    Console.WriteLine("All five integers are correct.");
            //                    if (value5 > maxValue)
            //                    {
            //                        maxValue = value5;
            //                    }
            //                    Console.WriteLine("Greatest value is: " + maxValue);

            //                }
            //                else
            //                {
            //                    Console.WriteLine("Incorect value!!!");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Incorect value!!!");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Incorect value!!!");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorect value!!!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Incorect value!!!");
            //}


        }
    }
}
