using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Bit_Position_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            // 11. Write a boolean expression that returns if 
            //     the bit at position p (counting from 0) in a given 
            //     integer number v has value of 1. Example: v=5; p=1  false.
            Console.Write("Insert number: ");
            int number = int.Parse(Console.ReadLine());
            
            Console.Write("Choose bit position: ");
            int position = int.Parse(Console.ReadLine());
            
            int mask = 1 << position;
            
            bool boolean = ((number & mask) >> position) == 1 ? true : false;
            Console.WriteLine("The bit at position "+ position +" in integer number "+ number + " has value of 1: "+boolean);


        }
    }
}
