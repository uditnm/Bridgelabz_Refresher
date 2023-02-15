using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsDay2
{
    internal class Factorial
    {
        public int factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n*factorial(n - 1);
        }
    }
}
