using System;

namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            while (t)
            {
                Console.WriteLine("1.Swap nibbles \n2.Generic BubbleSort \n3.Customize message \n4.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Binary b = new Binary();
                        Console.WriteLine("Enter the number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        b.toBinary(num);
                        break;
                    case 2:
                        BubbleSort bs = new BubbleSort();
                        Console.WriteLine("Enter the no. of elements");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the values:");
                        Console.WriteLine("1.int array \n2.string array \n3.float array");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                int[] arr = new int[n];
                                for (int i = 0; i < n; i++)
                                {
                                    arr[i] = Convert.ToInt32(Console.ReadLine());
                                }
                                bs.sort(arr);
                                break;
                            case 2:
                                string[] ar = new string[n];
                                for (int i = 0; i < n; i++)
                                {
                                    ar[i] = Console.ReadLine();
                                }
                                bs.sort(ar);
                                break;
                            case 3:
                                float[] a = new float[n];
                                for (int i = 0; i < n; i++)
                                {
                                    a[i] = Convert.ToSingle(Console.ReadLine());
                                }
                                bs.sort(a);
                                break;
                        }
                        
                        
                        break;
                    case 3:
                        CustomizeMessage cm = new CustomizeMessage();
                        cm.customize();
                        break;
                    case 4:
                        t = false;
                        break;
                }
            }
        }
    }
}
