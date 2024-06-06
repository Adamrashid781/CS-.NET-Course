using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string inputAge = Console.ReadLine();
            int age = Convert.ToInt32(inputAge);

            Console.WriteLine("Have you ever had a DUI?");
            string DUI = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string inputTickets = Console.ReadLine();
            int tickets = Convert.ToInt32(inputTickets);


            Console.WriteLine(age + "\n" + DUI + "\n" + tickets);

            if (age > 15 && DUI == "no" && tickets < 4) {
                Console.WriteLine("You qualify for insurance with us!");
            }


            Console.ReadLine();

        }
    }
}
