using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Binary
    {
        public void toBinary(int num)
        {
            string binary = Convert.ToString(num, 2);
            Console.WriteLine(binary);

            int right = num & 0b00001111;
            right = right << 4;
            int left = num & 0b11110000;
            left = left >> 4;

            int newnum = right | left;
            Console.WriteLine("The number after swap is: " + newnum);

            if (poweroftwo(newnum))
            {
                Console.WriteLine("It is a power of two");
            }
            else
            {
                Console.WriteLine("It is not a power of two");
            }

        }

        bool poweroftwo(int n)
        {
            if( n== 0)
            {
                return false;
            }
            while(n!=1)
            {
                if (n % 2 != 0)
                {
                    return false;
                }
                n /= 2;
            }
            return true;
        }
    }
}
