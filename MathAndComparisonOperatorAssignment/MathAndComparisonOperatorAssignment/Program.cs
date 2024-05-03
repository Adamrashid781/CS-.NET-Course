using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sadam Rashid\n5-2-2024\nC# and .NET Course\n\nAnonymous Income Comparison Program");


            // This block of code will get the hourly pay and hours worked for person 1
            Console.WriteLine("\nPerson 1");
            Console.WriteLine("What is their hourly rate?");
            string strPay1 = Console.ReadLine();
            float fPay1 = Convert.ToSingle(strPay1);

            Console.WriteLine("What is their hours worked every week?");
            string strHours1 = Console.ReadLine();
            float fHours1 = Convert.ToSingle(strHours1);

            // This block of code will get the hourly pay and hours worked for person 2
            Console.WriteLine("\nPerson 2");
            Console.WriteLine("What is their hourly rate?");
            string strPay2 = Console.ReadLine();
            float fPay2 = Convert.ToSingle(strPay2);

            Console.WriteLine("What is their hours worked every week?");
            string strHours2 = Console.ReadLine();
            float fHours2 = Convert.ToSingle(strHours2);



            // this block of code will calculate the annual sallary for person 1 and 2 
            float person1Salary = fPay1 * fHours1 * 52;
            float person2Salary = fPay2 * fHours2 * 52;


            // Writes out to the console the salary and then compares them
            Console.WriteLine("\nAnnual sallary of Person 1: " + Convert.ToString(person1Salary));
            Console.WriteLine("Annual sallary of Person 2: " + Convert.ToString(person2Salary));

            Console.WriteLine("\nDoes person 1 make more money than person 2?");
            bool isTrue = person1Salary > person2Salary;
            Console.WriteLine(Convert.ToString(isTrue));
            Console.ReadLine();

        }
    }
}
