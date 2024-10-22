using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Example
{
    class Program
    {
        static void Main()
        {
            // Specify the data source .
            string[] students = new string[] { "Lacy", "Trisha", "Gavin", "Josh", "Jon", "Landon", "Kyndreshia", "Sadam Rashid" };


            // Define the query expression. 
            IEnumerable<string> studentQuery =
                from student in students
                where student.Length >= 6
                select student; 

            // Execute the query 
            foreach (string s in studentQuery)
            {
                Console.Write(s + ", ");
            }
            Console.ReadLine();
        }
    }
}
