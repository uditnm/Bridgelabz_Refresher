using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class Findroots
    {
        public void roots(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            double root1, root2;

            if (discriminant > 0)
            {
                 root1 = (-b + Math.Sqrt(discriminant))/(2*a);
                 root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                 Console.WriteLine("root1 = "+ root1);
                 Console.WriteLine("root2 = "+ root2);
            }
            else if (discriminant == 0)
            {
                root1 = root2 = -b / (2 * a);
                Console.WriteLine("root1 = "+ root1);
                Console.WriteLine("root2 = "+ root2);
            }
            else
            {
                double real = -b / (2 * a);
                double imaginary = Math.Sqrt(-discriminant)/(2*a);
                Console.WriteLine($"root1 = {real}+{imaginary}i ");
                Console.WriteLine($"imaginary = {real}-{imaginary}i");
            }

            
        }
    }
}
