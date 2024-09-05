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
        public Employee(string name) : this(name, nameNull)
        {

        }
        public Employee(string FirstName, string LastName)
        {
            Fname = FirstName;
            Lname = LastName;
            Console.WriteLine("your name is: {0} {1}", Fname, Lname);
        }

    }
}
