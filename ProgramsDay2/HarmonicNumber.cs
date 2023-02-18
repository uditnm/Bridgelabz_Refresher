using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class HarmonicNumber
    {
        public void harmonic(int n)
        {
            float harmonicnum=0;
            for(float i=1;i<=n;i++)
            {
                harmonicnum += 1/i;
            }
            Console.WriteLine("The nth harmonic number is: " + harmonicnum);
        }
    }
}
