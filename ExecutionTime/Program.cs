using System;
using System.Diagnostics;

namespace ExecutionTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            sw.Stop();
            Console.WriteLine("Execution time: " + sw.Elapsed);
        }
    }
}