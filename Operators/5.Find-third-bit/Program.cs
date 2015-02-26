using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Find_third_bit
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Write a boolean expression for finding 
            // if the bit 3 (counting from 0) of a given integer is 1 or 0.

            Console.Write("Въведете число: ");
            int x = int.Parse(Console.ReadLine());

            int y = 1; // 0000 0001
            y = 1 << 3; // 0000 1000  or 8

            int bit = x & y;// exapmle x = 9 0000 1001
                          //           y = 8 0000 1000
                          //           x & y 0000 1000

            bit = bit >> 3; // 0000 0001
            Console.WriteLine("bit 3 (counting from 0) of {0} is: {1}", x, bit);

        }
    }
}
