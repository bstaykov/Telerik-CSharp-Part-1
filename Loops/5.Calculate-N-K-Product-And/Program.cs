using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Calculate_N_K_Product_And
{
    class Program
    {
        static void Main(string[] args)
        {
            //  5. Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
            Console.Write("Insert 1<N<K\n");
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            int factK = 1, factN = 1;

            if (n > 1 && k > n)
            {
                int diference = k - n;
                int fackD = 1;

                while (k > 1)
                {
                    factK = factK * k;
                    k = k - 1;
                }
                Console.WriteLine("K! = " + factK);

                while (n > 1)
                {
                    factN = factN * n;
                    n = n - 1;
                }

                while (diference > 1)
                {
                    fackD = fackD * diference;
                    diference = diference - 1;
                }
                Console.WriteLine("N! = " + factN);

                Console.WriteLine("N!*K! = " + (factN * factK));

                Console.WriteLine("(K-N)! = " + fackD);

                Console.WriteLine("(N!*K!)/(K-N)! = " + (factN * factK)/fackD);

            }
            else
            {
                Console.WriteLine("Try diferent numbers!!!");
            }
        }
    }
}
