using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class CashCounter
    {
        public void balance()
        {
            Queue<int> queue = new Queue<int>();
            Console.WriteLine("Enter the number of customers");
            int n = Convert.ToInt32(Console.ReadLine());
            int balance = 0;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("1.Deposit \n2.Withdraw");
                int ch = Convert.ToInt32(Console.ReadLine());
                foreach(int j in queue)
                {
                    balance += j;
                }
                switch(ch)
                {
                    case 1:
                        int amount = Convert.ToInt32(Console.ReadLine());
                        queue.Enqueue(amount);
                        break;
                    case 2:
                        if (queue.Count != 0)
                        {
                            queue.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds");
                        }
                        break;


                }
            }
        }
    }
}
