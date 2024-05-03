using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 22;

            int a = num1 + num2;

            float b = num2 - a;

            float c = num1 * b;

            float d = b / num1;

            Console.WriteLine("A: " + a + "\nB: " + b + "\nC: " + c + "\nD: " + d);
            Console.ReadLine();
        }
    }
}
