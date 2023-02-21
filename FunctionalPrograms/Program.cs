using System;

namespace FunctionalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            while (t)
            {
                Console.WriteLine("1.2D Array \n2.Sum of three integers adds to zero \n3.Euclidean Distance " +
                    "\n4.Quadratic roots \n5.WindChill \n6.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Array2D array2d = new Array2D();
                        Console.WriteLine("Enter the rows and columns:");
                        int m = Convert.ToInt32(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("1.Integer array \n2.Double array \n3.boolean array");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                array2d.readintarray(m, n);
                                break;
                            case 2:
                                array2d.readdoublearray(m, n);
                                break;
                            case 3:
                                array2d.readbooleanarray(m, n);
                                break;
                        }

                        break;
                    case 2:
                        SumofIntegers si = new SumofIntegers();
                        si.integersumzero();
                        break;
                    case 3:
                        Distance distance = new Distance();
                        Console.WriteLine("Enter x and y:");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        distance.euclideandistance(x, y);
                        break;
                    case 4:
                        QuadraticRoots qr = new QuadraticRoots();
                        Console.WriteLine("Enter a,b and c: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        qr.findroots(a, b, c);
                        break;
                    case 6:
                        t = false;
                        break;
                }
            }
        }
    }
}
