using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        const string nameNull = "Doe";

        // This constructoer will take the first name a user inputs when they dont
        // put a last name and pass both vars to the second constructor
        public Employee(string name) : this(name, nameNull)
        {

        }

        // This constructor will take the first name and the standard last name or the user
        // inputed last name and assign it to the object and print the whole name to the console
        public Employee(string FirstName, string LastName)
        {
            Fname = FirstName;
            Lname = LastName;
            Console.WriteLine("your name is: {0} {1}", Fname, Lname);
        }

    }
}
