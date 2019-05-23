using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaOperators
{
    class Program
    {
        private static void SetOperators()
        {
            int[] arr1 = { 2, 4, 6, 8, 10 };
            int[] arr2 = { 3, 6, 9, 12, 15 };

            var intersection = arr1.Intersect(arr2);
            Console.WriteLine("Intersection...");
            foreach(var item in intersection)
            {
                Console.WriteLine(item);
            }
            var difference = arr1.Except(arr2);
            Console.WriteLine("difference");
            foreach(var item in difference)
            {
                Console.WriteLine(item);
            }
        }
        private static void AggregationOperator()
        {
            int[] numbers = { 54, 76, 87, 327, 99 };
            Console.WriteLine("sum ={0}",numbers.Sum());
            Console.WriteLine("Min ={0}", numbers.Min());
            Console.WriteLine("Max ={0}", numbers.Max());
            Console.WriteLine("Average ={0}", numbers.Average());
            Console.WriteLine("Count ={0}", numbers.Count());

        }
        private static void ElementOperator()
        {
            string[] empty = { };
            string[] topic = { "Lambda" };
            string[] notempty = { "Hello", "World" };

            var result = empty.FirstOrDefault(); //null
            Console.WriteLine(result);

            result = notempty.Last(); //World
            Console.WriteLine(result);

            result = notempty.ElementAt(1);  //World
            Console.WriteLine(result);

            //result=empty.First();   //InvalidOperationException
            //Console.WriteLine(result);

            //result=notEmpty.Single();   //InvalidOperationException
            //Console.WriteLine(result);

            result = topic.Single();
            Console.WriteLine(result);

            result = notempty.First(s => s.StartsWith("W"));
            Console.WriteLine(result);

        }
        static void Main(string[] args)
        {
            ElementOperator();
            AggregationOperator();
        }
    }
}
