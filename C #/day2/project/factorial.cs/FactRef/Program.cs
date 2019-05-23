using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactRef
{
    class Program
    {
        /// <summary>
        /// Calc method for Factorial Logic
        /// </summary>
        /// <param name="args"></param>
        public void Calc(int n, ref int f)
        {
            for(int i=1;i<=n; i++)
            {
                f = f * i;
            }  
       }
        static void Main(string[] args)
        {
            int n, f = 1;
            Console.WriteLine("enter N value");
            n = Convert.ToInt32(Console.ReadLine());
            new Program().Calc(n, ref f);
            Console.WriteLine($"Factorial {f}");
        }
    }
}
