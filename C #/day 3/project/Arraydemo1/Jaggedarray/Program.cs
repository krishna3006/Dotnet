using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaggedarray
{
    class Program
    {
        public void Show()
        {
            int[][] arr = new int[2][];
            int[] a1 = new int[] { 12, 5, 77, 52 };
            int[] a2 = new int[] { 66, 21, 743, 68, 124, 254 };
            arr[0] = a1;
            arr[1] = a2;
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr[i].Length;j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            new Program().Show();
        }
    }
}
