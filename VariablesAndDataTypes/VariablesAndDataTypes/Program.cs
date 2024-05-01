using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("your favorite number plus 5 is " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -23;
            char randomLetter = 'X';
            char questionMark = '\u2103';
            Console.WriteLine(questionMark);

            decimal moneyInBank = 300.5m;

            double heightInCentimeters = 211.09876898768;

            float secondsLeft = 2.62f;

            short tempOnMars = -341;

            string myName = "Adam";

            int currentAge = 23;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainStatus);


            Console.ReadLine();

        }
    }
}
