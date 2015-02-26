using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Exchange_Integer_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int temp;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a = " + a + "\nb = " + b + "\n");
        }
    }
}
