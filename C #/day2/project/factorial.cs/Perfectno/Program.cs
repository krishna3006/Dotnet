using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfectno
{
    class Program
    {
        public void Perfect(int n)
        {
            int c = 0;
            for (int i=(n-1);i>0;i--)
            {
                if(n%i==0)
                {
                    c = c + i;
                }

            }
            if (c == n)
            {
                Console.WriteLine($"{c} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{c} is not a perfect number");
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            new Program().Perfect(n);
        }
    }
}
