using System;

namespace ProgramsDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Program \n1.Factorial \n2.Print 1 to 100 \n3.Find roots of quadratic equation \n4.Number to String \n5.Check String");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: 
                    Factorial fact = new Factorial();
                    Console.WriteLine("Enter a number: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The factorial is: " + fact.factorial(n));
                    break;
                case 2:
                    Print1to100 obj = new Print1to100();
                    obj.printnumbers();
                    break;
                
                case 3:
                    Findroots fr = new Findroots();
                    Console.WriteLine("Enter the coefficients");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double b = Convert.ToDouble(Console.ReadLine());
                    double c = Convert.ToDouble(Console.ReadLine());
                    fr.roots(a, b, c);
                    break;
                case 4:
                    NumbertoString nts= new NumbertoString();
                    Console.WriteLine("Enter number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    nts.numtostring(num);
                    break;
                case 5:
                    CheckString cs = new CheckString();
                    Console.WriteLine("Enter the string");
                    string str = Console.ReadLine();
                    cs.checkstr(str);
                    break;
            }
            

                    


        }
    }
}
