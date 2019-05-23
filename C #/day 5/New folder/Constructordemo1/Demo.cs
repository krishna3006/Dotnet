using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructordemo1
{
    class Demo
    {
        static Demo()
        {
            Console.WriteLine("Static Constructor...");
        }
        public Demo()
        {
            Console.WriteLine("Instance Constructr");
        }
        ~Demo()
        {
            Console.WriteLine("Destructor fired...");
        }
        static void Main(string[] args)
        {
            Demo obj = new Demo();
        }
    }
}
