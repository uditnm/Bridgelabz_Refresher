using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class SimulatedStopwatch
    {
        public void watch()
        {
            Console.WriteLine("Press s to start and q to stop");
            
            Stopwatch stopwatch = Stopwatch.StartNew();
            bool end = false;
            while (!end)
            {
                char ip = Convert.ToChar(Console.ReadLine());
                switch (ip)
                {
                    case 's':
                        stopwatch.Start();
                        break;
                    case 'q':
                        stopwatch.Stop();
                        end = true;
                        break;

                }
            }

            Console.WriteLine("Elapsed time is: "+stopwatch.Elapsed);
            
        }
    }
}
