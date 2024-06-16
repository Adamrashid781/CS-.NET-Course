using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Adam";
            string qoute = "the man said \"Hello\", Adam. \n Hello on a new line. \n \t hello on a tab!";

            string filePath1 = "C:\\Users\\Adam";
            // or rather than using double back slashes, use an @ to say that everything inside the string is a aprt of the string
            string filePath2 = @"C:\Users\Adam";


            bool trueOrFalse = name.Contains("d");

            trueOrFalse = name.EndsWith("m");
            int length = name.Length;

            name = name.ToUpper();

            Console.WriteLine(qoute);
            Console.WriteLine(trueOrFalse);
            Console.WriteLine(length);
            Console.WriteLine(name + " In all CAPS");
            name = name.ToLower();
            Console.WriteLine(name + " In lower CAPS");


            StringBuilder sb = new StringBuilder();
            sb.Append("My name is adam");
            Console.WriteLine(sb);

            if (!trueOrFalse)
            {
                Console.WriteLine("your name does not contain the letter 'D'");
            }
            else { Console.WriteLine("Your name contains the letter 'D'");  }

            Console.ReadLine();
        }
    }
}
