using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Declare_Int_Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 254;
            Console.WriteLine(number);

            int numberHex = 0xFE;
            Console.WriteLine("FE = " + numberHex);
        }
    }
}
