using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class
            Math math = new Math();


            // A static class cannot be instantiated
            // StaticTest Static = new StaticTest();

            // Asking the user for the input
            Console.WriteLine("Enter a number to pass to the method and divide it by 2: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int sum; 
            math.Divide(userInput);
            


            Console.WriteLine("Enter another number please");
            userInput = Convert.ToInt32(Console.ReadLine());
            math.Multiply(userInput, out sum);
            Console.WriteLine("{0} * 6 = {1}", userInput, sum);

            int result = StaticTest.Add(userInput, 3000);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
