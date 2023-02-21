using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class Array2D
    {
        public void readintarray(int m, int n)
        {

            int[,] arr = new int[m,n];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The array is: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

        public void readdoublearray(int m, int n)
        {
            double[,] arr = new double[m,n];


            Console.WriteLine("Enter the elements");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i,j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            Console.WriteLine("The array is: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void readbooleanarray(int m, int n)
        {
            bool[,] arr = new bool[m,n];


            Console.WriteLine("Enter the elements");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = Convert.ToBoolean(Console.ReadLine());
                }
            }

            Console.WriteLine("The array is: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
