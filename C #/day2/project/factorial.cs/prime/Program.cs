using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        public void Prime(int n, ref int x)
        {
            x = 1;
            for (int i=2;i<=n;i++)
            {
                if(n%i==0)
                {
                    x = 1;
                }

            }

        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter the number");
           int n =Convert.ToInt32(Console.ReadLine());
            int x = 0;
            new Program().Prime(n, ref x);
                if (x == 0)
                {
                Console.WriteLine("prime no");
                }
            Console.WriteLine("not prime");
        }
        
    }
}
