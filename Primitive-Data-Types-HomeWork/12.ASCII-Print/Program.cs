using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ASCII_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 127; i++)
            {

                System.Console.WriteLine("{0} = {1}", i, (char)i);

            }
        }
    }
}
