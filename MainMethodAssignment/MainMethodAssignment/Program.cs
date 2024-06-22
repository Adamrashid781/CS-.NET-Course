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
            decimal secondNum;

            int thirdNum, fourthNum;

            // Math operation 1
            Console.WriteLine("Enter a number to use in some math operation:");
            firstNum = Convert.ToInt32(Console.ReadLine());
            // Calling the overlaoded method and sending the user input into the Method
            math.Operation(firstNum);


            // Math operation 2
            Console.WriteLine("Enter a number to use in some math operation:");
            secondNum = decimal.Parse(Console.ReadLine());
            // Calling the overlaoded method and sending the user input into the Method 
            int b = math.Operation(secondNum);
            Console.WriteLine("20.7645 * {0} = {1}", secondNum, b);


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



            // Void method assignment 
            Console.WriteLine("Enter a number to be sent to the void method ");
            int fifthNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number to be sent to the void method ");
            int sixthNum = Convert.ToInt32(Console.ReadLine());
            math.MoreMath(fifthNum, sixthNum);

            Console.ReadLine();
        }
    }
}
