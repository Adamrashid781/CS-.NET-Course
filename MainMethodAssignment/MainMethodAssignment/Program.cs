using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an Object of type Math
            Math math = new Math() ;

            // Intstantiating the varaibles that will take in the user input for the first two operations
            int firstNum;
            float secondNum;
            
            // Math operation 1
            Console.WriteLine("Enter a number to use in some math operation:");
            firstNum = Convert.ToInt32(Console.ReadLine());
            // Calling the overlaoded method and sending the user input into the Method
            math.Operation(firstNum);


            // Math operation 2
            Console.WriteLine("Enter a number to use in some math operation:");
            secondNum = float.Parse(Console.ReadLine());
            // Calling the overlaoded method and sending the user input into the Method 
            math.Operation(secondNum);


            // Math operation 2
            Console.WriteLine("Enter a number to use in some math operation:");
            // Calling the overlaoded method and having it take the string, it will Parse through the string and pull a number
            math.Operation(Console.ReadLine());


            Console.ReadLine();
        }
    }
}
