using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class SecondLargestElement
    {
        public void secondlargest()
        {
            Console.WriteLine("Enter the no. of elements");
            int eln = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[eln];
            for (int i = 0; i < eln; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int largest = 0, secondlargest = -1;
            foreach(int i in arr)
            {
                if (i > largest)
                {
                    largest = i;
                }
            }

            foreach(int i in arr)
            {
                if(i!=largest && i > secondlargest)
                {
                    secondlargest = i;
                }
            }
            Console.WriteLine("Second largest element is: " + secondlargest);
        }
    }
}
