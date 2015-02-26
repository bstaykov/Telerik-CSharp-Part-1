using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Roots_of_quadratic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Write a program that reads the coefficients a, b and c 
            //    of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).


            Console.WriteLine("Insert 'a': ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert 'b': ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert 'c': ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("x = " + (-c / b));
            }
            else
            {
                double discriminant = b*b - 4*a*c;
                if (discriminant < 0)
                {
                    Console.WriteLine("Quadratic equation have no real roots!!!");
                }
                else if (discriminant == 0)
                {
                    Console.WriteLine("x1 = x2 = {0}", (-b/ (2 * a)));
                }
                else if (discriminant > 0)
                {
                    Console.WriteLine("x1 = {0}\nx2 = {1}", (-b + Math.Sqrt(discriminant)) / (2 * a), (-b - Math.Sqrt(discriminant)) / (2 * a));
                }
            }
        }
    }
}
