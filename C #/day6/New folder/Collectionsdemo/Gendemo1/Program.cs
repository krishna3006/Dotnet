using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Gendemo1
{
    class Program
    {
        public static void Swap(ref int x,ref int y)
        {
            int t;
            t = x;
            x = y;
            y = t;
        }
        static void Main(string[] args)
        {
            int a = 5,b= 7;
            Swap<int>(ref a, ref b);
            Console.WriteLine($"A value{a} B value{b}");
            double d1 = 12.5, d2 = 56.23;
            Swap<double>(ref d1, ref d2);
            Console.WriteLine($"A value{d1} B vaulue{d2}");
            string s1 = "Bhargav", s2 = "Krishna";
            Console.WriteLine("$ A value{s1} B value{s2}");

        }
    }
}
