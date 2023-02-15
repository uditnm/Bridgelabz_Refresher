
using System;

namespace NameParts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The number of parts in the name are " + args.Length);
            Console.WriteLine("The parts are:");
            foreach (Object obj in args)
            {
                Console.WriteLine(obj);
            }
        }
    }
}