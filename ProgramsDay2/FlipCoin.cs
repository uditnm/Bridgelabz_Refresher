using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class FlipCoin
    {
        public void flip(int n)
        {
            float heads = 0, tails = 0;
            double flip = 0;
            Random r = new Random();
            for(int i=0;i<n; i++)
            {
                flip = r.NextDouble();
                if (flip < 0.5)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }

            }

            Console.WriteLine("Percentage of Heads: " + heads / n);
            Console.WriteLine("Percentage of Tails: " + tails / n);
        }
    }
}
