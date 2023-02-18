using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class LeapYear
    {
        public void isLeap(int year)
        {
            if((year%400==0||year%100!=0) && year % 4 == 0)
            {
                Console.WriteLine("It is a Leap year");
            }
            else
            {
                Console.WriteLine("It is not a Leap year");
            }
        }
    }
}
