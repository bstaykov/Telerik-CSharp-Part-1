using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Console_read_Print_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете вашата възраст: ");
            string age = Console.ReadLine();
            int myAge = int.Parse(age);
            Console.WriteLine("След 10 години ще бъдете на " + (myAge + 10) + " години!!!");
        }
    }
}
