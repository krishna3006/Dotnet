using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegae2
{
    class Program
    {
        public delegate void Test(int n);
        public static void Check(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }

        }
        static void Main(string[] args)
        {
            Test obj = new Test(Check);
            obj(5);
          
        }
    }
}
