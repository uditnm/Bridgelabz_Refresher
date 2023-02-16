using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class ValidExpression
    {
        public void isvalid()
        {
            Regex r = new Regex(@"^(\d+(\.\d+)?[+\-/*])*");
            Console.WriteLine("Enter expression");
            string exp = Console.ReadLine();
            if (r.IsMatch(exp))
            {
                DataTable dt = new DataTable();
                Console.WriteLine("Expression is valid and answer is" + dt.Compute(exp, ""));

            }
            else
            {
                Console.WriteLine("Invalid Expression");
            }
        }
    }
}
