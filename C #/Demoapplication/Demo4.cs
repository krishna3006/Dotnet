using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoapplication
{
    class Demo4
    {
        public void Sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine($"sum of{a} and {b} is {c}");
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 2 numbers");
            a= Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Demo4 obj = new Demo4();
            obj.Sum(a, b);
        }
    }
}
