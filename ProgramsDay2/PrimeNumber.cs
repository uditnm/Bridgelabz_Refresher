using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class PrimeNumber
    {
        public void hasprime(int[] arr)
        {
            
            for(int i=0;i<arr.Length;i++)
            {
                int flag = 0;
                for (int j = 2; j * j <= arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine(arr[i]);
                    
                }
            }
            
        }
    }
}
