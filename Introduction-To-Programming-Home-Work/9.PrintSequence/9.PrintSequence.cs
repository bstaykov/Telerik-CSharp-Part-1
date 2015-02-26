using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PrintSequence
{
    class Program
    {
        static void Main(string[] args)
        {

            //вариант 1
            int a = 2, b = -3;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a);
                a += 2;
                Console.WriteLine(b);
                b += -2;
            }

            // вариант 2
            int a1 = 2;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(a1);
                    a1 = -a1 - 1;
                }
                else
                {
                    Console.WriteLine(a1);
                    a1 = -a1 + 1;
                }
            }
        }

    }
}
