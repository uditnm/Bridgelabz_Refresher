using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class Distance
    {
        public void euclideandistance(int x, int y)
        {
            double dist = Math.Pow((x * x + y * y),0.5);
            Console.WriteLine("The Euclidean distance is: "+ dist);
        }
    }
}
