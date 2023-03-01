using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    internal class CabInvoice
    {
  
        private List<int> invoices = new List<int>();
 
        public void CalculateFare()
        {
            Console.WriteLine("Enter no. of rides");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter Distance in km: ");
                int distance = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter time in mins: ");
                int time = Convert.ToInt32(Console.ReadLine());
                int fare = distance * 10 + time;
                if(fare>5)
                {
                    invoices.Add(fare);
                }
                else
                {
                    invoices.Add(5);
                }
                
            }
            
            Console.WriteLine("Total fare is: "+ TotalFare());

        }

        private int TotalFare()
        {
            int fare = 0;
            foreach(int invoice in invoices)
            {
                fare += invoice;
            }
            
            return fare;
        }


    }
}
