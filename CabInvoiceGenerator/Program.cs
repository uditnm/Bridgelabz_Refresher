using System;

namespace CabInvoiceGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            while(t)
            {
                Console.WriteLine("1.Enter ride \n2.Exit");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        
                        CabInvoice c = new CabInvoice();
                        c.CalculateFare();
                        break;
                    case 2:
                        t = false;
                        break;
                }
            }
            
        }
    }
}
