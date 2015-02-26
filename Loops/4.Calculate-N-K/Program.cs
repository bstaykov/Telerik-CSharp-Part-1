using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Calculate_N_K
{
    class Program
    {
        static void Main(string[] args)
        {
            //  6. Write a program that calculates N!/K! for given N and K (1<K<N).
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            int factN = 1;

            if (k > 1 && k < n)
            {
                //while (k > 1)
                //{
                //    factK = factK * k;
                //    k = k - 1;
                //}
                //Console.WriteLine("K! = " + factK);

                //while (n > 1)
                //{
                //    factN = factN * n;
                //    n = n - 1;
                //}
                //Console.WriteLine("N! + " + factN);

                //Console.WriteLine("N!/K! = " + factN/factK);

                while (k < n)
                {
                    factN = factN * n;
                    n = n - 1;
                }
                Console.WriteLine("N!/K! = " + factN);

            }
            else
            {
                Console.WriteLine("Try diferent numbers!!!");
            }
        }
    }
}
