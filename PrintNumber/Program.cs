using System;

namespace PrintNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            string num = Console.ReadLine();
            for (int i = 0; i < 10; i++)
                Console.Write(num);
        }
    }
}
