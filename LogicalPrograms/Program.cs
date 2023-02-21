using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            while(t)
            {
                Console.WriteLine("1.Gambler \n2.Coupon Numbers \n3.Simulate Stopwatch Program " +
                    "\n4.Tic Tac Toe Game \n5.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Gambler gambler = new Gambler();
                        Console.WriteLine("Enter the stake: ");
                        int stake = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the goal: ");
                        int goal = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the no. of times");
                        int times = Convert.ToInt32(Console.ReadLine());
                        gambler.gamble(stake, goal, times);
                        break;
                }
            }
        }
    }
}
