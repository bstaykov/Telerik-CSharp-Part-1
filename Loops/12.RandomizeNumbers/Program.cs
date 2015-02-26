using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomizeNumbers
{
    class Program
    {
        private static int[] numbers;
        private static Random ran;

        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }

            Console.WriteLine(string.Join(", ", numbers));

            while (true)
            {
                for (int i = 0; i < n; i++)
                {
                    ran = new Random();
                    int newPosition = ran.Next(0, n);
                    Swap(i, newPosition);
                }

                Console.WriteLine(string.Join(", ", numbers));
                Console.WriteLine("Press enter to shufle again.");
                Console.Write(Console.ReadLine());
            }
        }

        private static void Swap(int oldPosition, int newPosition)
        {
            int temp = numbers[oldPosition];
            numbers[oldPosition] = numbers[newPosition];
            numbers[newPosition] = temp;
        }
    }
}
