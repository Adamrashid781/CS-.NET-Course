using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validDay = false;

            while (!validDay)
            {
                try
                {


                    Console.WriteLine("What day of the week is it?");
                    string today = Console.ReadLine();
                    Console.WriteLine("user input: " + today);

                    Array Days = Enum.GetValues(typeof(Day));
                    for (int i = 0; i < Days.Length; i++)
                    {

                        if (Enum.TryParse(today, true, out Day day))
                        {
                            Console.WriteLine("You have a match!");
                            validDay = true; // to exit while loop
                            break;
                        }
                        else
                        {
                            // If user input is false, error statment will be thrown
                            throw new ArgumentException("Invalid Day");
                        }

                    }


                    Console.ReadLine();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            
        }
    }
    public enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
