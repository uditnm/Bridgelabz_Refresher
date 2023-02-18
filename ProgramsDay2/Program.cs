using PracticeProblems;
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
                    "at desired position \n13.Second largest element in array \n14.Remove all duplicates \n15.Smallest gap between array elements " +
                    "16.Flip coin \n17.Leap Year \n18.Power of Two \n19.Harmonic Number \n20.Factors \n21.Quotient and Remainder \n22.Swap two numbers " +
                    "\n23.Even or Odd \n24.Vowel or Consonant \n25.Largest among three numbers \n26.Exit");
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
                        Console.WriteLine("Enter no. of times to flip coin:");
                        int times = Convert.ToInt32(Console.ReadLine());
                        FlipCoin fc = new FlipCoin();
                        fc.flip(times);
                        break;
                    case 17:
                        LeapYear ly = new LeapYear();
                        Console.WriteLine("Enter the year (4 digits): ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        if (year > 999 && year < 10000)
                        {
                            ly.isLeap(year);
                        }
                        else
                        {
                            Console.WriteLine("Enter 4 digit year!");
                        }
                        break;
                    case 18:
                        PowerofTwo pt = new PowerofTwo();
                        Console.WriteLine("enter n: ");
                        int numb = Convert.ToInt32(Console.ReadLine());
                        pt.power(numb);
                        break;
                    case 19:
                        HarmonicNumber hn = new HarmonicNumber();
                        Console.WriteLine("enter n: ");
                        int N = Convert.ToInt32(Console.ReadLine());
                        hn.harmonic(N);
                        break;
                    case 20:
                        Factors f = new Factors();
                        Console.WriteLine("Enter the number: ");
                        int nn = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The factors are:");
                        f.factor(nn);
                        break;
                    case 21:
                        QuotientandRemainder qr = new QuotientandRemainder();
                        Console.WriteLine("Enter the dividend and divisor");
                        int A = Convert.ToInt32(Console.ReadLine());
                        int B = Convert.ToInt32(Console.ReadLine());
                        qr.division(A, B);
                        break;
                    case 22:
                        SwapNumbers sn = new SwapNumbers();
                        Console.WriteLine("Enter the 2 numbers:");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        sn.swap(num1, num2);
                        break;
                    case 23:
                        EvenorOdd eo = new EvenorOdd();
                        Console.WriteLine("Enter the number");
                        int number = Convert.ToInt32(Console.ReadLine());
                        eo.check(number);
                        break;
                    case 24:
                        VowelorConsonant vc = new VowelorConsonant();
                        Console.WriteLine("Enter the alphabet");
                        char ch = Convert.ToChar(Console.ReadLine().ToLower());
                        vc.checkAlphabet(ch);
                        break;
                    case 25:
                        LargestAmongThree lt = new LargestAmongThree();
                        Console.WriteLine("Enter the three numbers:");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        int z = Convert.ToInt32(Console.ReadLine());
                        int largest = lt.largest(x, y, z);
                        Console.WriteLine("The largest no. is: " + largest);
                        break;
                    case 26:
                        t = false;
                        break;
                            
                }
            }
            

                    


        }
    }
}
