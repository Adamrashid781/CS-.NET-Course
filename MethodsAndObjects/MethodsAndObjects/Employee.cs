using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Employee: Person, IQuittable 
    {
        public int Id { get; set; }

        // Creating the interface method from the inhertited class
        public void Quit()
        {
            Console.WriteLine("Program will now Quit... (No it wont)");
            //throw new NotImplementedException(); 
        }
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}.", this.FirstName, this.LastName);
        }

        public static bool operator== (Employee one, Employee two)
        {
            if(one.Id == two.Id)
            {
                Console.WriteLine("Both empployees have the same ID. This is not okay");
                two.Quit(); 
                return true;
            }
            else
            {
                Console.WriteLine("Both emploees have unique ID's");
                return false;
            }

            
        }
        public static bool operator!= (Employee one, Employee two)
        {
            if (one.Id != two.Id)
            {
                Console.WriteLine("Both emploees have unique ID's");
                return true;
            }
            else
            {
                Console.WriteLine("Both empployees have the same ID. This is not okay");
                return false;
            }

        }


    }
}
