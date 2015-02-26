using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Triangle_Print_C
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            //вариант 1
            char copySymbol = '\u00A9';
            Console.WriteLine("         " + copySymbol);
            Console.WriteLine("        " + copySymbol + " " + copySymbol);
            Console.WriteLine("       " + copySymbol + "   " + copySymbol);
            Console.WriteLine("      " + copySymbol + "     " + copySymbol);
            Console.WriteLine("     " + copySymbol + "       " + copySymbol);
            Console.WriteLine("    " + copySymbol + "         " + copySymbol);
            Console.WriteLine("   " + copySymbol + "           " + copySymbol);
            Console.WriteLine("  " + copySymbol + "             " + copySymbol);
            Console.WriteLine(" " + copySymbol + " " + copySymbol + " " + copySymbol + " " + copySymbol + " " + copySymbol + " " + copySymbol + " " + copySymbol + " " + copySymbol + " " + copySymbol);


            //вариант2
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < i+1; k++)
                {
                    Console.Write(copySymbol + " ");
                }
            }
            Console.WriteLine("\n\n");

            // вариант3

            for (int i = 0; i < 9; i++)
            {
                for (int n = 9 - i; n >= 0 ; n--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(copySymbol + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
