using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Extract_Bit_From_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            // 11. Write an expression that extracts from a given integer i 
            //     the value of a given bit index b. Example: i=5; b=2  value=1.

            Console.WriteLine("Insert number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose bit number: ");
            int bitIndex = int.Parse(Console.ReadLine());

            int mask = 1 << bitIndex; // for 3 is 0000 1000

            int extractedValue = (number & mask) >> bitIndex == 1 ? 1 : 0;
            Console.WriteLine("Bit's value at bit index " + bitIndex + " is: " + extractedValue);
        }
    }
}
