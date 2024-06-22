using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Math
    {
        public int Operation(int a)
        {
            int x = 20 + a;
            Console.WriteLine("20 + {0} = {1}", a, x);
            return x;
        }

        public int Operation(decimal a)
        {
            decimal x = a * 20.764588m;
            // This line converts the Float into an int
            int b = (int)x;

            

            return b;
        }

        public int Operation(string userString)
        {
            int a = Convert.ToInt32(userString);

            int c = 200 / a;

            Console.WriteLine("200 / {0} = {1}", a, c);

            return c;
        }


        // This is for the method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return an integer result.
        public int SomeMath(int a, int b = 1)
        {
            int x = a * (12 * b);

            Console.WriteLine("{0} X (12 X {1}) = {2}", a, b, x);

            return x;
        }

        // This is the void method that takes two integers as parameters. Have the method do a math operation on the first integer and display the second integer to the screen.
        public void MoreMath(int num1, int num2)
        {
            int x = num1 - 2;
            Console.WriteLine("{0} - 2 = {1}", num1, x);
            Console.WriteLine("The second integer you entered was {0}", num2);
        }
    }
}
