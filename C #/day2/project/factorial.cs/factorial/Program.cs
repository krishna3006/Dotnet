using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        public void factorial(int n,out int x)
        {
            x = 1;
            for(int i=1;i<=n;i++)
            {
                x = x * i;
            }
        }
        static void Main(string[] args)
        {
            int x, n;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            new Program().factorial(n, out x);
            Console.WriteLine($"fact is{x}");
        }
    }
}
