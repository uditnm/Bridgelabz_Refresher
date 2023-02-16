using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class Print1to100
    {
        public void printnumbers(int n = 100)
        {
            if (n == 1)
            {
                Console.WriteLine(n);
                return;
            }
            printnumbers(n - 1);
            Console.WriteLine(n);
        }
    }
}
