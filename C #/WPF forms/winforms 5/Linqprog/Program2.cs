using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqprog
{
    class Program2
    {
        static void Main(string[]args)
        {
            string[] names = new string[]
                {
                    "krishna","Bhargav","siva","Arun"
                };
            var result1 = from e in names select e;
            Console.WriteLine("Names are......");
            foreach(var v in result1)
            {
                Console.WriteLine(v);
            }
            var result2 = from e in names where e.StartsWith("B") select e;
            Console.WriteLine("Filtered......");
            foreach(var v in result2)
            {
                Console.WriteLine(v);
            }
            var result3 = from e in names orderby e select e;
            Console.WriteLine("Sorted...");
            foreach(var v in result3)
            {
                Console.WriteLine(v);
            }

        }
    }
}
