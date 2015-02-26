using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PrintRandomNumsInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert N = ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert MIN = ");
            int MIN = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert MAX = ");
            int MAX = int.Parse(Console.ReadLine());

            Random ran = new Random();

            for (int i = 0; i < N; i++)
            {
                Console.Write(ran.Next(MIN, MAX + 1) + " ");
            }
        }
    }
}
