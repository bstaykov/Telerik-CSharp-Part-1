using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Declare_Quated_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = "The \"use\" of quotations causes difficulties.";
            string line2 = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine(line1);
            Console.WriteLine(line2);
        }
    }
}
