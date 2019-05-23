using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factors
{
    class Program
    {
        public void Show(int n)
        {
            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine($"Factors {i}");
                    
                }
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter n value");
            n = Convert.ToInt32(Console.ReadLine());
            new Program().Show(n);
        }

    }
}
