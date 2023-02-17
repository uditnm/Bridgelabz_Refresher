using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class SmallestGap
    {
        public void smallestgap()
        {
            Console.WriteLine("Enter the no. of elements");
            int eln = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[eln];
            for (int i = 0; i < eln; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int gap = int.MaxValue;
            Array.Sort(arr);
            for(int i=0;i<arr.Length-1;i++)
            {
                if (arr[i + 1] - arr[i] < gap)
                {
                    gap = arr[i + 1] - arr[i];
                }
            }
            Console.WriteLine("Smallest gap: " + gap);
        }
    }
}
