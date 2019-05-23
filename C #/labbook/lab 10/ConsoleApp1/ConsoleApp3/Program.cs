using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRecordDay10
{
    class Program3
    {
        // delegate int MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("enter no.1:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter no.2:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Add\n2,2.Sub\n3,3.Mul\n4,4.Div\n5,5.Max");
            int ch = Convert.ToInt32(Console.ReadLine());
            Func<int, int, int> d;
            switch (ch)
            {
                case 1:
                    d = (x, y) => x + y;

                    break;
                case 2:
                    d = (x, y) => x - y;
                    break;
                case 3:
                    d = (x, y) => x * y;
                    break;
                case 4:
                    d = (x, y) => x / y;
                    break;
                case 5:
                    d = (x, y) => x > y ? x : y;
                    break;
                default:
                    d = (x, y) => x + y;
                    break;
            }
            Console.WriteLine(d(a, b));

            Console.ReadKey();

        }
    }
}


