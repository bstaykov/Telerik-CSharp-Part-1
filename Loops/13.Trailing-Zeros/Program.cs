using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Trailing_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {

            //   * Write a program that calculates for given N how many
            //        trailing zeros present at the end of the number N!. 
            
            Console.Write("Insert N:");
            int n = int.Parse(Console.ReadLine());        
            int count = 0;                            
            int power = 5;           
            while (n / power > 0)    
            {      
                count += n / power;
                power *= 5;
            }
            Console.WriteLine("number of trailing zeros in {0}! is {1}", n, count);
        }
    }
}
