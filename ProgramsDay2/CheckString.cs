using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class CheckString
    {
        public void checkstr(string str)
        {
            if(str.ToLower().Contains('a') && str.ToLower().Contains('e') && str.ToLower().Contains('p'))
            {
                Console.WriteLine("All Present");
            }
            else if(str.ToLower().Contains('a') || str.ToLower().Contains('e') || str.ToLower().Contains('p'))
            {
                Console.WriteLine("One or more - Present");
            }
            else
            {
                Console.WriteLine("None Present");
            }
        }
    }
}
