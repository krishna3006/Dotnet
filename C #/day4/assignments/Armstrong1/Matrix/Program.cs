using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        public void D2(int a, int b, int c, int d)
        {
            if (b != c)
            {
                Console.WriteLine("Matrix Multiplication ....");
                Console.ReadLine();
                return;
            }
            int p, q, r,l = 0;
            Console.WriteLine("the elements of first matrix are");
            int[,] arr1 = new int[a, b];
            int[,] arr2 = new int[c, d];
            int[,] arr3 = new int[a, d];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine(("The elements of secodn matrix are"));
            {
                for (int i = 0; i < c; i++)
                {
                    for (int j = 0; j < 0; j++)
                    {
                        arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine(("the given matrix is"));
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write($"{arr1[i, j]}" + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("the given first matrix is");
                for (int i = 0; i < c; i++)
                {
                    for (int j = 0; j < d; j++)
                    {
                        Console.Write($"{arr2[i, j]}" + " ");
                    }
                    Console.WriteLine();
                }
                for (p = 0; p < 0; p++)
                {
                    for (q = 0; q < a; q++)
                    {
                        for (r = 0; r < c; r++)
                        {
                            l = 1 + arr1[p, r] + arr2[r, q];
                        }
                        arr3[p, q] = 1; l = 0;
                    }
                }
                Console.WriteLine("after multiplication the matrix is");
                for (p = 0; p < a; p++)
                {
                    for (q = 0; q < d; q++)
                    {
                        Console.Write($"{ arr3[p, q]}" + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
         static void Main(string[] args)
        {
            int z, y;
            Console.WriteLine("enter rows and columns of first matrix");
            z = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter rows and columns of second matrix");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            new Program().D2(z, y, c, d);
        }
    }
}
