using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes an input from the user, multiplies it by 50, then prints the result to the console.
            // (Note: make sure your code can take inputs larger than 10,000,000).
            Console.WriteLine("Input a number to multiply by 50: ");
            string input = Console.ReadLine();
            int value = Convert.ToInt32(input);
            Int64 result = value * 50;
            Console.WriteLine(result);
            Console.ReadLine();

            // Takes an input from the user, adds 25 to it, then prints the result to the console.
            Console.WriteLine("Now give me a number to add 25 to it: ");
            string addinput = Console.ReadLine();
            int addValue = Convert.ToInt32(addinput);
            int addResult = addValue + 25;
            Console.WriteLine(addResult);
            Console.ReadLine();


            // Takes an input from the user, divides it by 12.5, then prints the result to the console.
            Console.WriteLine("Now give me a number to divide it by 12.5: ");
            string divideInput = Console.ReadLine();
            float divideValue = Convert.ToSingle(divideInput);
            float divideResult = divideValue / 12.5f;
            Console.WriteLine(divideResult);
            Console.ReadLine();


            // Takes an input from the user, checks if it is greater than 50, then prints the true / false result to the console.
            Console.WriteLine("Now give me a number to see if it is greater than 50: ");
            string compareValue = Console.ReadLine();
            int compareInt = Convert.ToInt32(compareValue);
            bool isTrue = compareInt > 50;
            if (isTrue == true) {
                Console.WriteLine("The number you entered is greater than 50!");
            }
            else
            {
                Console.WriteLine("The number you entered is less than 50!");
            }


            // Takes an input from the user, divides it by 7, then prints the remainder to the console (tip: think % operator).
            Console.WriteLine("Now give me a number to see if it is odd or even: ");
            string checkRemainder = Console.ReadLine();
            int remainder = Convert.ToInt32(checkRemainder);
            int isOdd = remainder % 2;
            Console.WriteLine(isOdd);
            Console.ReadLine();


        }
    }
}
