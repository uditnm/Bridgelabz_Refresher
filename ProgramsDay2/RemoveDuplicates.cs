using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class RemoveDuplicates
    {
        public void removedup()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Enter no. of elements");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                al.Add(Console.ReadLine());
            }

            for(int i = 0; i < al.Count-1; i++)
            {
                for(int j = i + 1; j < al.Count; j++)
                {
                    if (al[i].ToString() == al[j].ToString())
                    {
                        al.RemoveAt(j);
                    }
                }
            }

            

            foreach(var i in al)
            {
                Console.WriteLine(i);
            }
        }
    }
}
