using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void Max(int a, int b, int c)
        {
            if ((a > b) && (a > c))
            {
                Console.WriteLine("A is biggest"); }
            else if((b>a)&&(b>c))
            {
                Console.WriteLine("B is largest");
            }
            else
                Console.WriteLine("C is largest");
        }

            static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter three nums");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Program b1= new Program();
            b1.Max(a, b, c);
        }

    }
}
