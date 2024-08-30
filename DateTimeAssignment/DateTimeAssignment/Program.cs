using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a new variable of type DateTime to hold the current date and time
            DateTime time = DateTime.Now;

            // Taking in the user input of how many hours to add to the current DateTime
            Console.WriteLine( "{0} is the current time, enter a number:", time);
            int input = Convert.ToInt32(Console.ReadLine());

            // Using the AddHours() method to add the hours the user inputed onto the DateTime variable
            DateTime after = time.AddHours(input);

            Console.WriteLine(after);

            Console.ReadLine();
        }
    }
}
