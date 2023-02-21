using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNumber
    {
        public void coupons(int n)
        {
            int[] couponnum = new int[n];
            int newnum, count = 0, i = 0;
            Random r = new Random();
            while (i<n)
            {
                newnum= r.Next();
                count++;
                if(couponnum.Contains(newnum))
                {
                    continue;
                }
                couponnum[i++] = newnum;
                
            }

            Console.WriteLine("The coupon numbers are: ");
            foreach(int num in couponnum)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("The total random numbers generated were: " + count);
        }
    }
}
