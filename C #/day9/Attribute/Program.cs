using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Attributes sample");
            TestMethod();
            Console.ReadKey();
        }
        [Obsolete("deprecated Method", false)]
        public static void Testmethod()
        {
            Console.WriteLine("HelloWorld");
        }
    }
}

