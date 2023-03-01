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
        private Dictionary<int, (float, float)> invoicesrepo = new Dictionary<int, (float, float)>();
        float totalfare = 0;

        public float CalculateFare(List<(float, float)> rides)
        {
            int i = 1;
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
                invoicesrepo.Add(i, ride);
                i++;

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

        public (float,float) RetrieveRides(int id)
        {
            return invoicesrepo[id];
        }
    }
}
