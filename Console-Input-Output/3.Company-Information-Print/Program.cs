using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Company_Information_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. A company has name, address, phone number, fax number, web site and manager. 
            //The manager has first name, last name, age and a phone number. 
            //Write a program that reads the information about a company and its manager and prints them on the console.


            Console.Write("Insert the name of the company: ");
            string companyName = Console.ReadLine();

            Console.Write("Insert the address of the company: ");
            string companyAddress = Console.ReadLine();

            Console.Write("Insert phone number: ");
            ulong companyPhone = ulong.Parse(Console.ReadLine());

            Console.Write("Insert fax number: ");
            ulong companyFax = ulong.Parse(Console.ReadLine());

            Console.Write("Insert web site: ");
            string nameWeb = Console.ReadLine();

            Console.Write("Insert manager's first name: ");
            string managerFirstName = Console.ReadLine();

            Console.Write("Insert manager's last name: ");
            string managerLastName = Console.ReadLine();

            Console.Write("Insert manager's age: ");
            byte managerAge = byte.Parse(Console.ReadLine());

            Console.Write("Insert manager's phone number: ");
            ulong managerPhone = ulong.Parse(Console.ReadLine());

            Console.WriteLine("\nCompany name: {0} \nCompany address: {1} \nCompany phone: 0{2} \nCompany fax: 0{3} \n" 
                + "Web address: {4} \nManager: {5} {6} \nManager's age: {7} \nManager's phone: 0{8} \n", companyName, companyAddress, companyPhone, companyFax, nameWeb, managerFirstName, managerLastName, managerAge, managerPhone);

        }
    }
}
