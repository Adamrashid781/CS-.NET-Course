using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating Person class
            //Person person = new Person();

            // Instantiating Employee class
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            employee.Quit();


            //person.FirstName = "Adam";
            //person.LastName = "Rashid";

            //person.SayName();

            Console.ReadLine();
        }
    }
}
