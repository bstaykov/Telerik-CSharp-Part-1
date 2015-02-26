using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Assign_Float_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            // 34.567839023, 12.345, 8923.1234857, 3456.091

            float number1 = 34.567839023f; // не
            float number2 = 12.345f;
            float number3 =  8923.1234857f; // не
            float number4 = 3456.091f;

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);

            double number5 = 34.567839023; 
            double number6 = 12.345;
            double number7 = 8923.1234857;
            double number8 = 3456.091;

            Console.WriteLine(number5);
            Console.WriteLine(number6);
            Console.WriteLine(number7);
            Console.WriteLine(number8);

            // ИЗВОД: всички могат да бъдат 'double', но само '12.345' и '3456.091' могат да се присвояват на 'float' , за останалите две ще имаме загуба след седмия знак!

        }
    }
}
