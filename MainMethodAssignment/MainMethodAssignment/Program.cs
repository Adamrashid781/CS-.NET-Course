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
            Math math = new Math();

            // Intstantiating the varaibles that will take in the user input for the first two operations
            int firstNum;
            float secondNum;

            int thirdNum, fourthNum;

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


            // Block of code for the second Method assignment
            Console.WriteLine("Enter the first number to take into the math operation:");
            thirdNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number to take into the math operation:");
            string input = Console.ReadLine();

            // this if/else will check if the user made an input or not, then parse the input for a number
            if (string.IsNullOrWhiteSpace(input))
            {
                fourthNum = 1; // 1 is the defualt number set in the method
            }
            else
            {
                // this block will parse the code if there was an input
                bool accept = int.TryParse(input, out fourthNum);
                if (!accept)
                {
                    Console.WriteLine("Not a correct input! Using the defualt value.");
                    fourthNum = 1;
                }
            }

            math.SomeMath(thirdNum, fourthNum);


            Console.ReadLine();
        }
    }
}
