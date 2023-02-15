using System;

namespace SquareOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two numbers");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double squaresum = Math.Pow(num1 + num2, 2);
            double squarediff = Math.Pow(num1 - num2, 2);
            Console.WriteLine("The square of sum is: " + squaresum);
            Console.WriteLine("The square of difference is: " + squarediff);
        }
    }
}
