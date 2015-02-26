using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Trapezoid_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            // 09. Write an expression that calculates trapezoid's area 
            //    by given sides a and b and height h.

            Console.WriteLine("Insert value for 'a' : ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("insert value for 'b' : ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert value for 'h' : ");
            double h = double.Parse(Console.ReadLine());

            double area = (a + b) * 0.5 * h;
            Console.WriteLine("Area = " + area);







        }
    }
}
