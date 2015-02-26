using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
           // 3. Write an expression that calculates rectangle’s area by given width and height.

            Console.WriteLine("Insert width: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert width: ");
            int height = int.Parse(Console.ReadLine());

            int area = width * height;
            Console.WriteLine("Rectanle's area is = " + area);
            int perimeter = width * 2 + height * 2;
            Console.WriteLine("Rectanle's perimeter is = " + perimeter);


        }
    }
}
