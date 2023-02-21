using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class SumofIntegers
    {
        public void integersumzero()
        {
            Console.WriteLine("Enter no. of elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            int count = 0;

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i=0; i<n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    for(int k = j + 1; k < n; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            Console.Write(arr[i]+" "+arr[j]+" "+arr[k]+"\n");
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine("Total triples: "+count);
        }
    }
}
