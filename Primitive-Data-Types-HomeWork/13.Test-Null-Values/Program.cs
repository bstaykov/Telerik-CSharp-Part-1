using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Test_Null_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            //вариант1
            int? a = null;
            double? b = null;
            Console.WriteLine("''");

            Console.WriteLine(a);

            Console.WriteLine(b);

            Console.WriteLine("a = '" + a + "'");

            Console.WriteLine("b = '" + b + "'");

            a += 5;
            Console.WriteLine("a + 5 = '" + a + "'");

            b += null;
            Console.WriteLine("b + null = '" + b + "'");

            //вариант2
            Nullable<int> c = null;
            Console.WriteLine("c = '" + c + "'");





        
        }
    }
}
