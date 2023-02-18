using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class SwapNumbers
    {
        public void swap(int num1,int num2)
        {
            Console.WriteLine("The original numbers are: {0} {1}", num1, num2);
            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("The swapped numbers are: {0} {1}", num1, num2);
        }
    }
}
