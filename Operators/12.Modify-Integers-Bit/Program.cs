using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Modify_Integers_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            // 12. We are given integer number n, value v (v=0 or 1) 
            //     and a position p. Write a sequence of operators that modifies n 
            //     to hold the value v at the position p from the binary representation of n.

            Console.Write("Insert number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Choose value ( 0 or 1): ");
            int value = int.Parse(Console.ReadLine());

            Console.Write("Choose bit position: ");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:" + Convert.ToString(number, 2).PadLeft(16, '0'));

            int maskOne = 1 << position;
            int zero = 0;

            if (value == 1)
            {
                number = (number | maskOne);
            }
            if ( value == 0 )
            {
                number = (number ^ maskOne); // number 0111
                                             // mask   0100
                                             // result 0011
            }
            Console.WriteLine("After: " + Convert.ToString(number, 2).PadLeft(16, '0'));
        }
    }
}
