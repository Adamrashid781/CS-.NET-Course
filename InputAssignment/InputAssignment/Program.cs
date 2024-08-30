using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            // Storing the number as a string, not an int
            string input = Console.ReadLine();

            // Passing the string into the File.WriteAllText() method to write it to the .txt file
            File.WriteAllText(@"\\Mac\Home\Desktop\Log.txt", input);

            // pulling the data from the .txt file and passing it to the output variable to be printed to the console
            string output = File.ReadAllText(@"\\Mac\Home\Desktop\Log.txt");

            Console.WriteLine("Reading from file...\n" + output);

            Console.ReadLine();


        }
    }
}
