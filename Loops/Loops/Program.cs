using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number:");

            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;
            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 29:
                        Console.WriteLine("You guessed 29, try again please.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());

                        break;

                    case 55:
                        Console.WriteLine("You guessed 55, try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 12:
                        Console.WriteLine("You guessed the number 12, That is correct.");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);
            Console.ReadLine();


            bool isNum = false;
            int userInput = 0;

            while (!isNum)
            {
                Console.WriteLine("Input a odd number!");
                userInput = Convert.ToInt32(Console.ReadLine());
                

                if(userInput % 2 != 1)
                {
                    Console.WriteLine("You did not input an odd number, try again!");
                }
                else { isNum = true; Console.WriteLine("You put an odd number, program closing"); }
                
            }
            Console.ReadLine();
        }
    }
}
