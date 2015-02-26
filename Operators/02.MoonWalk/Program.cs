using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MoonWalk
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Weigth: ");
                double weigth;

                bool isParsed = double.TryParse(Console.ReadLine(), out weigth);

                if (isParsed)
                {
                    Console.WriteLine("Moonweigth: " + (weigth * 0.17));
                }
            }
        }
    }
}
