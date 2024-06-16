using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "adam";

            //if (name == "Jim")
            //{
            //    Console.WriteLine("Your name is Jim");
            //}
            //else if (name == "Tom")
            //{
            //    Console.WriteLine("Your name is Tom");
            //}
            //else if (name != "Ayia")
            //{
            //    Console.WriteLine("You are happy");
            //}

            //else
            //{
            //    Console.WriteLine("Your name is not Jim or Tom. Who TF are you");
            //}

            Console.WriteLine("Ternary Operators below:");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            int currentTemp = 80;
            Console.WriteLine("Hi, " + name + " What is the room temp?");
            int roomTemp = Convert.ToInt32(Console.ReadLine());

            string comparison = currentTemp == roomTemp ? "It is room temp" : "It is not room temp";
            Console.WriteLine(comparison);

            

            

            string answer = 5 > 2 ? "Num 1 is greater than num 2" : "num 2 is greater than num 1 ";
            Console.WriteLine(answer);

            string names = name != "adam" ? "your name is adam" : "Name is not adam ";
            Console.WriteLine(names);


           

            Console.ReadLine();
        }
    }
}
