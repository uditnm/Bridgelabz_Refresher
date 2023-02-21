using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Gambler
    {
        public void gamble(int stake, int goal, int times)
        {
            double outcome;
            double win = 0, loss = 0;
            Random r = new Random();
            for(int i=0;i<times;i++)
            {
                while (stake != 0)
                {
                    outcome = r.NextDouble();
                    if (outcome > 0.5)
                    {
                        stake++;
                        if (stake == goal)
                        {
                            win++;
                            break;
                        }
                    }
                    else
                    {
                        stake--;
                    }
                }
                if (stake == 0)
                {
                    loss++;
                }
            }

            Console.WriteLine("Gambler won {0} times", win);
            Console.WriteLine("Gambler lost {0} times", loss);
            Console.WriteLine("Percentage of win: " + (win / times) * 100);
            Console.WriteLine("Percentage of loss: " + (loss / times) * 100);
        }
    }
}
