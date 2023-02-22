using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class CustomizeMessage
    {
        public void customize()
        {
            string message = "Hello <<name>>, We have your full " +
                "name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx. " +
                "Please,let us know in case of any clarification Thank you BridgeLabz 01/01/2016.";

            string namepattern = @"<<name>>";
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            message = Regex.Replace(message, namepattern, name);

            string fullnamepattern = @"<<full name>>";
            Console.WriteLine("Enter fullname: ");
            string fullname = Console.ReadLine();
            message = Regex.Replace(message, fullnamepattern, fullname);

            string numpattern = @"91-x{10}";
            Console.WriteLine("Enter number: ");
            string num = Console.ReadLine();
            message = Regex.Replace(message, numpattern, num);

            string datepattern = @"\d{2}/\d{2}/\d{4}";
            Console.WriteLine("Enter Date: ");
            string date = Console.ReadLine();
            message = Regex.Replace(message, datepattern, date);

            Console.WriteLine(message);
        }
    }
}
