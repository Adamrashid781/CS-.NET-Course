using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions.");
            Console.WriteLine("Enter the package weight?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            int packageWidth, packageHeight, packageLength, packageDimensions;

            if ( packageWeight < 50)
            {
                Console.WriteLine("What is the package width?");
                packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the package height");
                packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the packages length");
                packageLength = Convert.ToInt32(Console.ReadLine());

                packageDimensions = packageWidth + packageLength + packageHeight;
                if (packageDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped VIA Package Express.");
                }
                else
                {
                    int shippingCost = (packageWeight * packageHeight * packageWidth * packageLength) / 100;

                    Console.WriteLine("Your total cost for shipping is: " + shippingCost.ToString("C"));
                }
            }


            else
            {
                Console.WriteLine("Package is too heavy to be shipped VIA Package Express. Have a good day.");

            }

            

            Console.ReadLine();
        }
    }
}
