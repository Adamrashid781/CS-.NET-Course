using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your last name");
            var lname = Console.ReadLine();

            // This if statement will pass the first name and last name to the constructor
            // only if the user inputs a last name and first name
            if(name != "" && lname != "")
            {
                Employee emp1 = new Employee(name, lname);
            }
            // This else statement will fire rather than the if statement
            // if the user does not put in a last name
            else
            {
                Employee emp1 = new Employee(name);
            }
            

            

            Console.ReadLine();
        }
    }
}
