using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // takes a na,e then concatenates another name to the list of names in the string 
            string names = "Adam";
            names = names + ", Aya";
            names = names + ", Yusra";

            Console.WriteLine(names);
            // Converts names in list to Upper case
            string NAMES = names.ToUpper();
            Console.WriteLine(NAMES);

            // using String builder to make a paragraph in a loop

            bool repetition = false;
            int i = 0;
            StringBuilder para = new StringBuilder();
            while (!repetition)
            {
                Console.WriteLine("Enter a sentence to add to/create a paragraph:");
                para.Append(Console.ReadLine() + " ");

                Console.WriteLine(para);
                i++;
                if(i == 3)
                {
                    repetition = true;
                }
            }

            Console.ReadLine();
        }
    }
}
