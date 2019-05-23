using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refex1
{
    class Program
    {
        public void Incr(ref int x)
        {
            x++;

        }
        static void Main(string[] args)
        {
            int x = 12;
            new Program().Incr(ref x);
            Console.WriteLine($"x value is {x}");
        }
    }
}
