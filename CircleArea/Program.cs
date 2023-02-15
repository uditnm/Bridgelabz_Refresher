using System;

namespace CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the diameter");
            double diameter = Convert.ToDouble(Console.ReadLine());
            double radius = diameter / 2;
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("Area: " + area);
        }
    }
}
