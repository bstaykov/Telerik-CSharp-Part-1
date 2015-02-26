using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Declare_String_And_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName = "Svetlin", lastName = "Nakov";
            Object fullNameObject = firstName + " " + lastName;
            
            string fullNameString = (String)fullNameObject;
            Console.WriteLine("String: " + fullNameString);
            Console.WriteLine("Object: " + fullNameObject);
        }
    }
}
