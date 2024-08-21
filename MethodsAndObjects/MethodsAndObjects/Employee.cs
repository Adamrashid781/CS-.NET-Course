using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Employee<T>: Person, IQuittable 
    {
        public Employee()
        {
            // instantiating generic list and made it public so the objects can access it
            things = new List<T>();
        }
        public int Id { get; set; }

        public List<T> things { get; set; }

        //created this method so we can add data to the lists, cannot use "Add()" in main program, need this method. 
        public void AddThing(T thing)
        {
            things.Add(thing);
        }
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

        //public static bool operator== (Employee<T> one, Employee<T> two)
        //{
        //    if(one.Id == two.Id)
        //    {
        //        Console.WriteLine("Both empployees have the same ID. This is not okay");
        //        two.Quit(); 
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Both emploees have unique ID's");
        //        return false;
        //    }

            
        //}
        //public static bool operator!= (Employee<T> one, Employee<T> two)
        //{
        //    if (one.Id != two.Id)
        //    {
        //        Console.WriteLine("Both emploees have unique ID's");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Both empployees have the same ID. This is not okay");
        //        return false;
        //    }

        //}


    }
}
