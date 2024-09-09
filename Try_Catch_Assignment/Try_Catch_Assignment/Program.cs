using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 0;
            try
            {
                Console.WriteLine("What is your age?");
                age = Convert.ToInt32(Console.ReadLine());
                // If the user enteres a value below 0, it will throw a FormatException()
                if (age < 0) throw new FormatException();
                // If the user enteres a value of 0, it will throw a DivideByZeroException() 
                if (age == 0) throw new DivideByZeroException();

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error. Do not enter Zero for your age!");
                Console.ReadLine();
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error. Do not enter a negative number!");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Error, Retry inputing only a number.");
                Console.ReadLine();
                return;
            }
            

            // Grabbing the current datetime from the machine
            DateTime currentDate = DateTime.Today;

            // pulling only the year from the currentDate variable with the .year method
            int year = currentDate.Year;

            int dateOfBirth = year - age;

            Console.WriteLine("Your age is {0}, and you were born in {1}.", age, dateOfBirth);
            Console.ReadLine();
        }
    }
}
