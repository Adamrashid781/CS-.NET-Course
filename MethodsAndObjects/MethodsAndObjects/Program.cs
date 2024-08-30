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
            Employee<string> employee1 = new Employee<string>();
            Employee<int> employee2 = new Employee<int>();
             
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            employee2.Id = 2;
            employee1.SayName();

            employee2.FirstName = "Adam";
            employee2.LastName = "Rashid";
            employee2.Id = 2;
            employee2.SayName();

            // Adding data to the lists with Method AddThing
            employee1.AddThing("Hello,");
            employee1.AddThing(" World");
            employee2.AddThing(2001);
            employee2.AddThing(2004);

            for(int i = 0; i < employee1.things.Count; i++)
            {
                Console.WriteLine(employee1.things[i]);
            }

            for(int i = 0; i < employee2.things.Count; i++)
            {
                Console.WriteLine(employee2.things[i]);
            }

            // bool isTrue = employee1.Id == employee2.Id;

            // Console.WriteLine(isTrue);  

            // Calling the Interface
            employee1.Quit();


            //person.FirstName = "Adam";
            //person.LastName = "Rashid";

            //person.SayName();

            Console.ReadLine();
        }
    }
}
