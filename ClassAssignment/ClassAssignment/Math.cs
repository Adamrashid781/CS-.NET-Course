using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class  Math
    {
        public void Divide(int num1)
        {
            int x = num1 / 2;
            Console.WriteLine("{0} / 2 = {1}", num1, x);

        }
        public void Multiply(int num1, out int sum)
        {
            sum = num1 * 6;
            // Console.WriteLine("{0} / 2 = {1}", num1, sum);

        }
    }
}
