using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Math = new Class1();
            int classReturn = 0;

            // this block will take user input and add it to 2, then display the total
            Console.WriteLine("What number do you want to add 2 to? ");
            classReturn =  Math.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("You are returned with: " + classReturn);

            // this block will take user input and subtract 2 from it, then display the total
            Console.WriteLine("What number do you want to subract 2 from?");
            classReturn = Math.Subract(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("You are returned with: " + classReturn);

            // this block will take user input and multiply it by 2, then display the total
            Console.WriteLine("What number do you want to multiply by 2?");
            classReturn = Math.Multiply(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("You are returned with: " + classReturn);



            Console.ReadLine();

        }
    }
}
