using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class QuotientandRemainder
    {
        public void division(int a, int b)
        {
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine("The quotient is: " + quotient);
            Console.WriteLine("The remainder is: " + remainder);
        }
    }
}
