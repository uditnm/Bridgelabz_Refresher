using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class RepeatedElement
    {
        public void isrepeat()
        {
            Console.WriteLine("Enter the no. of elements");
            int eln = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[eln];
            for (int i = 0; i < eln; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < eln; i++)
            {
                for(int j=i+1; j < eln; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        Console.WriteLine("First repeat is: " + arr[i]);
                        return;
                    }
                }
            }
            Console.WriteLine("No repeat"); 
        }
    }
}
