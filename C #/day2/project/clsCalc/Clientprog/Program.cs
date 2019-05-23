using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsCalc;
namespace Clientprog
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter 2 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Calc obj = new Calc();
            c = obj.Sum(a, b);
            Console.WriteLine($"Sum is {c}");
            c = obj.Sub(a, b);
            Console.WriteLine($"Sub is {c}");
            c = obj.Mult(a, b);
            Console.WriteLine($"Mult is {c}");
        }

    }
}
