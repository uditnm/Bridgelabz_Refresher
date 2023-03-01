using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class CabInvoice
    {
  
        private List<float> invoices = new List<float>();
        float totalfare = 0;

        public float CalculateFare(List<(float, float)> rides)
        {

            foreach (var ride in rides)
            {
                float fare = ride.Item1 * 10 + ride.Item2;
                if (fare > 5)
                {
                    invoices.Add(fare);
                }
                else
                {
                    invoices.Add(5);
                }

            }
            
            foreach (int invoice in invoices)
            {
                totalfare += invoice;
            }

            return totalfare;

        }

        public int TotalRides()
        {
            return invoices.Count();
        }

        public float AverageFare()
        {
            return totalfare/ invoices.Count();
        }
    }
}
