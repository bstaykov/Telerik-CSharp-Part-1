using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Check_if_inside_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Write an expression that checks if given point (x,  y) is within a circle K(O, 2).
            Console.WriteLine("Insert value for x: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert value for y: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Point A ({0}, {1})", x, y);

            if (Math.Sqrt(x * x + y * y) < 2)
            {
                Console.WriteLine("Точката (" + x + ", " + y + ") е вътре в окръжноста.");
            }
            else
            {
                if (Math.Sqrt(x * x + y * y) == 2)
                {
                    Console.WriteLine("Точката (" + x + ", " + y + ") лежи на окръжноста.");
                }
                else
                {
                    if (Math.Sqrt(x * x + y * y) > 2)
                    {
                        Console.WriteLine("Точката (" + x + ", " + y + ") е извън окръжноста.");
                    }
                }
            }
        }
    }
}
