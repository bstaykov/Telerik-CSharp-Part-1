using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sum_With_Accuracy
{
    class Program
    {
        static void Main(string[] args)
        {

            //  10. Write a program to calculate the sum 
            //      (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

            float sum = 1f;
            int sign = 1;
            //int counter = 0;
            
            for (int i = 2; (1f / i) > 0.001f; i++)
            {
                sum = sum + (1f / i) * sign;
                sign = sign * (-1);

                //counter++;
                //Console.WriteLine(counter+ " : " + 1f/i);  // remove comMents to find out how many times the loop goes!
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
