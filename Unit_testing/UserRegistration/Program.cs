using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public bool CheckFirstName(string name)
        {
            string pattern = @"^[A-Z][a-z][a-z].*";
            Regex regex = new Regex(pattern);
            if(regex.IsMatch(name))
            {
                Console.WriteLine("Valid");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid");
                return false;
            }
        }

        public bool CheckLastName(string name)
        {
            string pattern = @"^[A-Z][a-z][a-z].*";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(name))
            {
                Console.WriteLine("Valid");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid");
                return false;
            }
        }

        public bool CheckEmail(string mail)
        {
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(mail))
            {
                Console.WriteLine("Valid");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid");
                return false;
            }
        }

        public bool CheckPhone(string num)
        {
            string pattern = @"^\d{2}\s\d{10}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(num))
            {
                Console.WriteLine("Valid");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid");
                return false;
            }
        }

        public bool CheckPassword(string pw)
        {
            string pattern = @"^(?=.*[0-9])(?=.*[A-Z])(?=[^@!#$%&*\\]*[@!#$%&*\\][^@!#$%&*\\]*$)([a-zA-Z0-9!@#$%&*\\]{8,})$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(pw))
            {
                Console.WriteLine("Valid");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid");
                return false;
            }
        }
    }
}
