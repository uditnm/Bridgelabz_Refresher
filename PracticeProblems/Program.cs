using System;

namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            while (t)
            {
                Console.WriteLine("1.Swap nibbles \n2.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Binary b = new Binary();
                        Console.WriteLine("Enter the number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        b.toBinary(num);
                        break;
                    case 2:
                        t = false;
                        break;
                }
            }
        }
    }
}
