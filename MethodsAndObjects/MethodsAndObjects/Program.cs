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
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            employee2.Id = 2;
            employee1.SayName();

            employee2.FirstName = "Adam";
            employee2.LastName = "Rashid";
            employee2.Id = 2;
            employee2.SayName();

            bool isTrue = employee1.Id == employee2.Id;

            Console.WriteLine(isTrue);  

            // Calling the Interface
            employee1.Quit();


            //person.FirstName = "Adam";
            //person.LastName = "Rashid";

            //person.SayName();

            Console.ReadLine();
        }
    }
}
