using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Creating the list that has random number in it
                List<int> numList = new List<int>() { 2, 4, 5, 8, 22, 99, 90, 0 };

                // Displaying the numbers with a simple foreach loop
                foreach (int num in numList)
                {
                    Console.WriteLine(num);
                }

                // Taking the user input asa float
                Console.WriteLine("\n\nInput a number to divide all the number in the list by:");

                // Using the float.Parse() function to take in a user input that is a flaot
                // If user enters a Zero, it will not throw a error, in order to correct that, there needs
                // to be some if statements to catch this
                float userInput = float.Parse(Console.ReadLine());

                // creating the variable to assign the result to
                float x = 0;

                // This foreach loop divides the numbers in the list one at a time by the userInput variable
                // and assigns it to x. 
                //Using the (dataType)Math.Round(var, 2) function to round the sum to 2 decimal places
                foreach (int num in numList)
                {
                    x = num / userInput;
                    x = (float)Math.Round(x, 2);
                    // This if statement will tell the user that they are dividing by zero and equal infinity
                    if (float.IsInfinity(x))
                    {
                        Console.WriteLine(num + " / " + userInput + " Result is infinity, do not input a Zero.");
                    }
                    else
                    {
                        Console.WriteLine(num + " / " + userInput + " Equals: " + x);
                    }
                   
                }
            }

            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program executed and exited the catch blocks.");
                Console.ReadLine();
            }
            
        }
    }
}
