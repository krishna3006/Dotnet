
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxminarray
{
    class Program
    {
        public void Array1(int a)
        {
            int[] arr = new int[a];
            Console.WriteLine("enter the elements");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine($"min is{arr[0]} max is {arr[a - 1]}");
        }
        static void Main(string[] args)
        { 
         int n;
         Console.WriteLine("how many elements in the array");
            n=Convert.ToInt32(Console.ReadLine());
        new Program().Array1(n);
        }
    }
}
