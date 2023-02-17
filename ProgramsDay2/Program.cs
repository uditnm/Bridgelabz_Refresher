using System;

namespace RefresherPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            while(t) { 
                Console.WriteLine("Choose Program \n1.Factorial \n2.Print 1 to 100 \n3.Find roots of quadratic equation" +
                    " \n4.Number to String \n5.Check String \n6.Average of Array \n7.Prime Number in integer array \n8.Shift zeros to end of array " +
                    "\n9.First repeated element in array \n10.Arithmetic expression \n11.Longest substring without repeating characters \n12.Delete an element " +
                    "at desired position \n13.Second largest element in array \n14.Remove all duplicates \n15.Smallest gap between array elements \n16.Exit");
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
                        NumbertoString nts = new NumbertoString();
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
                    case 6:
                        AverageofArray avgarr = new AverageofArray();
                        Console.WriteLine("Enter the no. of elements");
                        int ele = Convert.ToInt32(Console.ReadLine());
                        float[] arr = new float[ele];
                        for(int i = 0; i < ele; i++)
                        {
                            arr[i] = Convert.ToSingle(Console.ReadLine());
                        }
                        float avg = avgarr.average(arr);
                        Console.WriteLine("The average of the array is: "+ avg);
                        break;
                    case 7:
                        PrimeNumber pn = new PrimeNumber();
                        Console.WriteLine("Enter the no. of elements");
                        int eln = Convert.ToInt32(Console.ReadLine());
                        int[] ar = new int[eln];
                        for (int i = 0; i < eln; i++)
                        {
                            ar[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Prime numbers are: ");
                        pn.hasprime(ar);
                        break;
                    case 8:
                        ShiftZeroes sz = new ShiftZeroes();
                        Console.WriteLine("Enter the no. of elements");
                        int elem = Convert.ToInt32(Console.ReadLine());
                        int[] array = new int[elem];
                        for (int i = 0; i < elem; i++)
                        {
                            array[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        sz.shift(array);
                        break;
                    case 9:
                        RepeatedElement re = new RepeatedElement();
                        re.isrepeat();
                        break;
                    case 10:
                        ValidExpression ve = new ValidExpression();
                        ve.isvalid();
                        break;
                    case 11:
                        LongestSubstring ls = new LongestSubstring();
                        Console.WriteLine("Enter String:");
                        string s = Console.ReadLine();
                        ls.longestsubstr(s);
                        break;
                    case 12:
                        DeleteArrayElement de = new DeleteArrayElement();
                        de.deletefromarray();
                        break;
                    case 13:
                        SecondLargestElement sl = new SecondLargestElement();
                        sl.secondlargest();
                        break;
                    case 14:
                        RemoveDuplicates rd = new RemoveDuplicates();
                        rd.removedup();
                        break;
                    case 15:
                        SmallestGap sg = new SmallestGap();
                        sg.smallestgap();
                        break;
                    case 16:
                        t = false;
                        break;
                            
                }
            }
            

                    


        }
    }
}
