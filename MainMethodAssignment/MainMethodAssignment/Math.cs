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

        public int Operation(float a)
        {
            float x = a * 20.7645f;
            // This line converts the Float into an int
            int b = (int)x;

            Console.WriteLine("20.7645 * {0} = {1}", a, b);

            return b;
        }

        public int Operation(string userString)
        {
            int a = Convert.ToInt32(userString);

            int c = 200 / a;

            Console.WriteLine("200 / {0} = {1}", a, c);

            return c;
        }
    }
}
