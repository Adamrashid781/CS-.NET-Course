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

        public void Quit()
        {
            Console.WriteLine("Program will now Quit... (No it wont)");
            //throw new NotImplementedException(); 
        }
        
    }
}
