using System;

namespace NextDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a month [1-12]: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a day [1-31]: ");
            int day = Convert.ToInt32(Console.ReadLine());

            if (month == 2)
            {
                if (day == 28)
                {
                    if ((year % 400 == 0 || year % 100 != 0) && year % 4 == 0)
                    {
                        day++;
                    }
                    else
                    {
                        day = 1;
                        month++;
                    }
                }

                else if (day == 29)
                {
                    day = 1;
                    month++;
                }
                else
                {
                    day++;
                }
            }

            else if (month == 4|| month == 6|| month == 9 || month == 11)
            {
                if (day == 30)
                {
                    day = 1;
                    month++;
                }
                else
                {
                    day++;
                }
            }
            else
            {
                if (day == 31)
                {
                    day = 1;
                    if (month == 12)
                    { 
                        month = 1;
                        year++;
                    }
                    else
                    {
                        month++;
                    }
                }
                else
                {
                    day++;
                }
            }

            Console.WriteLine("The next day is: "+day+"-"+month+"-"+year);
        }
    }
}
