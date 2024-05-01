using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report.\n\nWhat is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", what course are you on?");

            string course = Console.ReadLine();

            Console.WriteLine("And what page number of the " + course + " course are you currently on?");

            string strPage = Console.ReadLine();
            // This line converts the string number to an int
            int pageNum = Convert.ToInt32(strPage);

            Console.WriteLine(name + ", do you need help with anything? Please answer 'true' or 'false'");
            bool help;
            string answer = Console.ReadLine();
            // This block of code will take the users string response of true/false and flip the switch for the bool
            if (answer == "true")
            {
                help = true;
            }
            else
            {
                help = false;
            }

            Console.WriteLine("Were there any positive experiences you'd like to share? Please be specific.");
            string experience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedBack = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
