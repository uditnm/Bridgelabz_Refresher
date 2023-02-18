using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Factors
    {
        public void factor(int n)
        {
            while(n%2==0)
            {
                Console.WriteLine(2);
                n /= 2;
            }

            for(int i=3; i*i<=n; i += 2)
            {
                while(n%i==0)
                {
                    Console.WriteLine(i);
                    n /= i;
                }
            }

            if (n > 2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
