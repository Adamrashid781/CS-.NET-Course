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

            if(name != "" && lname != "")
            {
                Employee emp1 = new Employee(name, lname);
            }
            else
            {
                Employee emp1 = new Employee(name);
            }
            

            

            Console.ReadLine();
        }
    }
}
