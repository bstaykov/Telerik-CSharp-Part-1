using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Calculate_N_K_SUM
{
    class Program
    {
        static void Main(string[] args)
        {
            //  5. Write a program that, for a given two integer numbers N and X,
            //     calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN


            Console.WriteLine("Insert X and N >= 1");
            Console.Write("X = ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            double factN = 1;
            double sum = 1;
            double pow = 1;

            if (n > 0)
            {
                for (int i = 1; i <= n; i++) // S = 1 + 1!/X + 2!/X2 + … + N!/XN
                {
                    pow = pow * x;
                    factN = factN * i;
                    sum = sum + factN / pow;
                }
                Console.WriteLine("Sum = {0:0.00}", sum);
            }
            else
            {
                Console.WriteLine("N must be greater than '0'. Try again!!!");
            }

        }
    }
}
