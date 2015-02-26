using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Character_Assign_Symbol
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0x2A;
            Console.WriteLine("Hexadecimal '2A' = " + number);
            char charHex = '\x002A';
            Console.WriteLine("Symbol that has Unicode code '42' is: '" + charHex + "'");
        }
    }
}
