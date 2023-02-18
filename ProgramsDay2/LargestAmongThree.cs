using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class LargestAmongThree
    {
        public int largest(int x, int y, int z)
        {
            int largestnum;
            
            if (x >= y && x >= z)
            {
                largestnum = x;
            }
            else if (y >= x && y >= z)
            {
               largestnum = y;
            }
            else 
            {
               largestnum = z;
            }

            return largestnum;
        }
        
        
    }
}
