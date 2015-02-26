using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Print_Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int[,] array = new int[number, number];
            int counter = 1;
            int rowIndex = 0; 
            int colIndex = 0;
            int maxRowIndex = number - 1; 
            int maxColIndex = number - 1;
            Console.WriteLine();

            do
            {
                for (int i = colIndex; i <= maxColIndex; i++) 
                {
                    array[rowIndex, i] = counter;      
                    counter++;            
                }                                                                                     
                rowIndex++;            
                for (int i = rowIndex; i <= maxRowIndex; i++) 
                {                                                                                   
                    array[i, maxColIndex] = counter;    
                    counter++; 
                }
                maxColIndex--;  
                for (int i = maxColIndex; i >= colIndex; i--)  
                {                                              
                    array[maxRowIndex, i] = counter;               
                    counter++;
                }
                maxRowIndex--; 
                for (int i = maxRowIndex; i >= rowIndex; i--)
                {
                    array[i, colIndex] = counter;                               
                    counter++;
                }
                colIndex++;
            } 
            while (counter <= number * number); 

            for (int rows = 0; rows < array.GetLength(0); rows++)
            {
                for (int cols = 0; cols < array.GetLength(1); cols++)
                {
                    Console.Write(array[rows, cols] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
        }
    }
}
