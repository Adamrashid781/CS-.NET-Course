using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment Part 1
                // Creating an array of strings then itterating through it to add texts
                string[] texts = new string[3];

                for (int i = 0; i < texts.Length; i++)
                {
                    Console.WriteLine("Type up a message to put in the Array: ");
                    texts[i] = Console.ReadLine();
                }
                // Itterating through the array to print off each text
                foreach (string text in texts)
                {
                    Console.WriteLine(text);
                }


            // Assignemnt Part 2
                // Infinite Loop
                bool isTrue = false;
                int ticker = 0;
                while (!isTrue)
                {
                    Console.WriteLine("THIS IS AN ENDLESS LOOP. YOU ARE STUCK IN THE MATRIX!");
                    // This code below will stop the endless loop after 10 iterations
                    ticker++;
                    if (ticker == 10)
                    {
                        isTrue = true;
                        Console.WriteLine("PHEW!! That was smart thinking, we are safe now!");
                    }
                }


            // Assignment Part 3
                // Loop comparing with the < Operator 
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("This is the " + i + " itteration");
                }

                // Loop comparing with the <= operator
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine("This is the " + i + " itteration");
                }


            // Assignment Part 4


                bool isFound = false;
                while (!isFound)
                {
                    // List of unique strings  
                    List<string> someText = new List<string>() { "adam", "aya", "moe", "22" };

                    // Print the List
                    foreach (string text in someText)
                    {
                        Console.WriteLine(text);
                    }

                    // prompt user to search for one
                    Console.WriteLine("Enter which text to be compared to the list to search for please");
                    string selection = Console.ReadLine();

                    // Checks user input for matches in the Array in a loop until a match is found
                    foreach (string text in someText)
                    {
                        // If theres a match
                        if (text.Contains(selection))
                        {
                            Console.WriteLine(text);
                            isFound = true;
                        }
                    }
                    // If there is no match
                    if (!isFound)
                    {
                        Console.WriteLine("Nothing matches that search!");
                    }
                }


            // Assignment Part 5

                // A List with at least two identical strings 
                List<string> moreText = new List<string>() { "This is sentence one.", "This is sentence one.",
                                                                "This is sentence two.", "This is sentence three."};

                // Printing List
                foreach (string text in moreText)
                {
                    Console.WriteLine(text);
                }

                // Take the user input
                Console.WriteLine("What text do you want to look for in the list?");
                string userInput = Console.ReadLine();


                // Loop that iterates through the List and finds matches to user input 
                bool textIsFound = false;
                int index = 0;
                foreach (string text in moreText)
                {
                    if (text.Contains(userInput))
                    {
                        
                        Console.WriteLine("The " + index + ". index contains a match!");
                        textIsFound = true;
                    }
                    index++;
                }

                if (!textIsFound)
                {
                    Console.WriteLine("Your text was not found in the entire List!");
                }

            // Assignemnt Part 6
                // Creating a list of strings with at least two identical strings
                List<string> finalText = new List<string>() { "A", "B", "C", "D", "C", "E"};

                // Creating a new blank list to move all of the non-duplicates over
                List<string> isUnique = new List<string>();

                // This block of code will evaluate if a string is a duplicate or unique
                foreach (string text in finalText)
                {
                    // This checks if the current string is in the new List, if so it will say it is a duplicate
                    if (isUnique.Contains(text))
                    {
                        Console.WriteLine("This item is a duplicate ");
                        
                    }
                    // This else statement will move the new text into the new List to be checked for a duplicate
                    // on the next iteration, and will say it is unique
                    else
                    {
                        Console.WriteLine("This item is unique. ");
                        isUnique.Add(text);
                    }
                    
                }

            Console.ReadLine();
            
        }
    }
}
