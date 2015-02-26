using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Compare_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber =  1.2345670001m;
            decimal secondNumber = 1.234567001m;
            decimal thirtdNumber = 1.234569m;
            decimal forthNumber = 123.123223m, 
                    fifthNumber = 123.123222m;

            Console.WriteLine((Double)Math.Abs(firstNumber - secondNumber) < 0.000001);
            Console.WriteLine((Double)Math.Abs(thirtdNumber - secondNumber) < 0.000001);
            Console.WriteLine((Double)Math.Abs(secondNumber - firstNumber) < 0.000001);
            Console.WriteLine((Double)Math.Abs(forthNumber - fifthNumber) < 0.000001);

        }
    }
}
