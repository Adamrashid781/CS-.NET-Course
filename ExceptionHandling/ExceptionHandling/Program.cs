using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pick another number");
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dividing the two...");

                int numberThree = number1 / number2;

                Console.WriteLine(number1 + " Divided by " + number2 + " equals: " + numberThree);
                Console.ReadLine();
            }
            // You can put as many catch blocks as youd like and only the ones that apply to the error made will execute
            // But even if there is no error, the Finally catch block will execute regardless
            // ex is of datatype FormatException
            catch(FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please dont divide by zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Usually a database Log will be in here, for passes and fails
                Console.ReadLine();
            }
            
            
        }
    }
}
