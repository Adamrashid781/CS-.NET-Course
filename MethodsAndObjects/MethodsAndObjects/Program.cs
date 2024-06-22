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
            Person person = new Person();
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();


            person.FirstName = "Adam";
            person.LastName = "Rashid";

            person.SayName();

            Console.ReadLine();
        }
    }
}
