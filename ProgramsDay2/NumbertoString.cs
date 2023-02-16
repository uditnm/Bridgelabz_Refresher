using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class NumbertoString
    {
        public void numtostring(int num)
        {
            StringBuilder sb = new StringBuilder();
            if (num % 3 == 0)
            {
                sb.Append("Pling");
            }
            if (num % 5 == 0)
            {
                sb.Append("Plang");
            }
            if (num % 7 == 0)
            {
                sb.Append("Plong");
            }

            Console.WriteLine(sb);
        }
    }
}
