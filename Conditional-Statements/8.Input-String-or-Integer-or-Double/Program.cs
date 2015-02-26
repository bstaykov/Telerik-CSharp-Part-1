using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Input_String_or_Integer_or_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9. Write a program that, depending on the user's choice
            //    inputs int, double or string variable. If the variable 
            //    is integer or double, increases it with 1. 
            //    If the variable is string, appends "*" at its end. 
            //    The program must show the value of that variable 
            //    as a console output. Use switch statement.

            Console.Write("Input '1' for 'Integer' , '2' for 'Double' or '3' for 'String': ");
            string input = Console.ReadLine();
            int choice;
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("\nInput 'Integer' : ");
                        string choiceInteger = Console.ReadLine();
                        int valueInteger;
                        if (int.TryParse(choiceInteger, out valueInteger))
                        {
                            Console.WriteLine("\nOutput: {0}\n", valueInteger + 1);
                        }
                        else
                        {
                            Console.WriteLine("\nIncorect input!!!\n");
                        }
                        break;
                    
                    case 2: 
                        Console.Write("\nInput 'Double' : ");
                        string choiceDouble = Console.ReadLine();
                        double valueDouble;
                        if (double.TryParse(choiceDouble, out valueDouble))
                        {
                            Console.WriteLine("\nOutput: {0}\n", (valueDouble + 1));
                        }
                        else
                        {
                            Console.WriteLine("\nIncorect input!!!\n");
                        }
                        break;
                    
                    case 3:
                        Console.Write("\nInput 'String': ");
                        string valueString = Console.ReadLine() + "*";
                        Console.WriteLine("\nOutput: {0}\n", valueString);
                        break;
                    
                    default: Console.WriteLine("\nMust choose between 1, 2 or 3!!! Try again!!!\n"); break;
                }
            }
            else
            {
                Console.WriteLine("\nIncorect input!!!\n");
            }

        }
    }
}
