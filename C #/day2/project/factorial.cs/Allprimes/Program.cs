using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allprimes
{
    class Program
    {
        public void Prime(int n)
        {
            for(int i=1;i<=n;i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                    {
                        Console.WriteLine($"the prime no is {i}");

                    }
                
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            new Program().Prime(n);
        }
    }
}
