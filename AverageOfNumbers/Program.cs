using System;

namespace AverageOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            float sum = 0;
            for (int i = 0; i < 5; i++)
            {
                int generatednum = rand.Next(10, 50);
                sum += generatednum;
                Console.Write(generatednum + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Average: " + sum / 5);
        }
    }
}
