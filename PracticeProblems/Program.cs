using System;
using System.Text.RegularExpressions;

namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            while (t)
            {
                Console.WriteLine("1.Swap nibbles \n2.Generic BubbleSort \n3.Customize message \n4.Unordered list \n5.Balanced parantheses \n6.Cash Counter \n7.Inventory \n8.Stock Account Management \n9.Exit");
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
                        SplitWords sw = new SplitWords();
                        sw.split();
                        break;
                    case 5:
                        BalancedParantheses bp = new BalancedParantheses();
                        Console.WriteLine("Enter the expression");
                        string exp = Console.ReadLine();
                        Console.WriteLine("The expression {0} balanced", bp.balance(exp) ? "is" : "is not");
                        break;
                    case 6:
                        CashCounter cc = new CashCounter();
                        cc.balance();
                        break;
                    case 7:
                        JSONInventory inventory = new JSONInventory();
                        inventory.inventory();
                        break;
                    case 8:
                        Console.WriteLine("Enter stock name:");
                        string stock = Console.ReadLine();
                        Console.WriteLine("Enter no. of shares: ");
                        int shares = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter share prices: ");
                        int price = Convert.ToInt32(Console.ReadLine());

                        Stock s = new Stock(stock,shares,price);
                        s.stockvalue();
                        break;
                    case 9:
                        t = false;
                        break;
                }
            }
        }
    }
}
