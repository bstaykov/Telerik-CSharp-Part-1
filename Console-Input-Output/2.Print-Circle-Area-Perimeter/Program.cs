using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Print_Circle_Area_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Write a program that reads the radius r of a circle and prints its perimeter and area.

            while (true)
            {
                Console.Write("Insert value for radius: ");
                double radius = double.Parse(Console.ReadLine());

                Console.WriteLine("{0, -25} {1:0.00}", "Area = PI.r.r =", Math.PI * radius * radius);
                Console.WriteLine("{0, -25} {1:0.00}", "Perimeter = 2.PI.r =", 2 * Math.PI * radius);

                Console.WriteLine("Press 'Enter' to try again...");
                Console.ReadKey();
            }
        }
    }
}
