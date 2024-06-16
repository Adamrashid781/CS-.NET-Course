using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_A_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 5:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("You have chosen case 1");
                    break;

                case 2:
                    Console.WriteLine("You have chosen case 2");
                    break;

                case 3:
                    Console.WriteLine("You have chosen case 3");

                    break;

                case 4:
                    Console.WriteLine("You have chosen case 4");

                    break;

                case 5:
                    Console.WriteLine("You have chosen case 5");

                    break;

                default:
                    Console.WriteLine("YOU have not chosen one");
                    break;
            
            }
            Console.ReadLine();
        }
    }
}
