using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class BubbleSort
    {
        public void sort<T>(T[] arr) where T:IComparable
        {
            int n = arr.Length;
            for(int i = 0; i < n-1; i++)
            {
                for(int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j].CompareTo(arr[j+1])>0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }

            for(int i=0;i<n;i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        
    }
}
