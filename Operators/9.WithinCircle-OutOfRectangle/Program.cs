using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.WithinCircle_OutOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10. Write an expression that checks for given point (x, y) 
            // if it is within the circle K( (1,1), 1.5) 
            // and out of the rectangle R(top=1, left=-1, width=6, height=2).

            // малко пояснение: 'R(top=1, left=-1, width=6, height=2)', това според мен означава че 
            // правоъгълника има горен ляв ъгъл т.(1, -1)

            Console.WriteLine("Въведете x: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Въведете y: ");
            double y = double.Parse(Console.ReadLine());

            if (Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5) // вътре в кръга
            {
                if (x >= -1 && x <= 1 && y >= -1 && y <= 1)
                {
                    Console.WriteLine("Точката (" + x + ", " + y + ") е вътре в окръжноста и във правоъгълника.");
                }
                else
                {
                    Console.WriteLine("Точката (" + x + ", " + y + ") е вътре в окръжноста но извън правоъгълника.");
                }

            }
            else
            {
                Console.WriteLine("Точката (" + x + ", " + y + ") е извън в окръжноста");
            }

        }
    }
}
