using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class DeleteArrayElement
    {
        public void deletefromarray()
        {
            Console.WriteLine("Enter the no. of elements");
            int eln = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[eln];
            for (int i = 0; i < eln; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter position to delete");
            int pos = Convert.ToInt32(Console.ReadLine());

            for(int i=pos;i<arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }

            Console.WriteLine("New list is: ");
            for(int i = 0; i < eln - 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
