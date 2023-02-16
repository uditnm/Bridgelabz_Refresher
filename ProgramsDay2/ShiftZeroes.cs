using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class ShiftZeroes
    {
        public void shift(int[] arr)
        {
            int i = 0;
            for(int j=0;j<arr.Length;j++)
            {
                if (arr[j] != 0)
                {
                    arr[i] = arr[j];
                    i++;
                }
            }

            for(int j=i;j<arr.Length;j++)
            {
                arr[j] = 0;
            }

            for(int k=0;k<arr.Length;k++)
            {
                Console.Write(arr[k]+" ");
            }
            Console.WriteLine();
        }
    }
}
