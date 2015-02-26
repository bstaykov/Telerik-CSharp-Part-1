using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Divede_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Write a boolean expression that checks for given integer 
            // if it can be divided (without remainder) by 7 and 5 in the same time.

            while (true)
            {
                Console.WriteLine("Insert integer : ");
                int x;
                bool isParsed = int.TryParse(Console.ReadLine(), out x);

                if (isParsed)
                {
                    if (x % 5 == 0 && x % 7 == 0)
                    {
                        Console.WriteLine("x = " + x + " can be divided (without remainder) by 7 and 5 in the same time.");
                    }
                    else
                    {
                        Console.WriteLine("x = " + x + " can not be divided (without remainder) by 7 and 5 in the same time.");
                    }

                    continue;
                }                          
            }

            //// не е част от домашното
            //Console.WriteLine("\nSome EXTRA");
            //Console.WriteLine("Insert integer : ");
            //int y = int.Parse(Console.ReadLine());
            //for (int i = 0; i < y; i++)
            //{
            //    if (i % 5 == 0 && i % 7 == 0)
            //        Console.WriteLine(i + " can be divided (without remainder) by 7 and 5 in the same time.");
            //}
        }
    }
}
