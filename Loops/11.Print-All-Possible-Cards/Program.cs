using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Print_All_Possible_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            //     Write a program that prints all possible cards 
            //     from a standard deck of 52 cards (without jokers). 
            //     The cards should be printed with their English names. 
            //     Use nested for loops and switch-case.
            
            for (int i = 2; i < 14; i++)
            {
                
                for (int j = 1; j < 5; j++)
                {
                    switch (i)
                    {
                        case 2:  Console.Write("Two"); break;
                        case 3:  Console.Write("Three"); break;
                        case 4:  Console.Write("Four"); break;
                        case 5:  Console.Write("Five"); break;
                        case 6:  Console.Write("Six"); break;
                        case 7:  Console.Write("Seven"); break;
                        case 8:  Console.Write("Eight"); break;
                        case 9:  Console.Write("Nine"); break;
                        case 10: Console.Write("Ten"); break;
                        case 11: Console.Write("Jack"); break;
                        case 12: Console.Write("Queen"); break;
                        case 13: Console.Write("King"); break;
                        case 14: Console.Write("Ace"); break;
                        default:
                            break;
                    }
                    Console.Write(" of ");

                    switch (j)
                    {
                        case 1: Console.WriteLine("Clubs"); break;
                        case 2: Console.WriteLine("Diamonds"); break;
                        case 3: Console.WriteLine("Hearts"); break;
                        case 4: Console.WriteLine("Spades"); break;
                        default:
                            break;
                    }

                }
                Console.WriteLine();

            }
        }
    }
}
