using System;
using System.Globalization;

namespace Placename
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            Console.WriteLine("Enter the place");
            string place = Console.ReadLine();
            Console.WriteLine("You entered: " + myTI.ToTitleCase(place));
        }
    }
}
