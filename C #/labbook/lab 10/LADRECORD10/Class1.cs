using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRecordDay10
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int Add() => a + b;
            int Subtract() => a - b;
            int Multiply() => a * b;
            Console.WriteLine("Addition:{0}", Add());
            Console.WriteLine("Subtraction:{0}", Subtract());
            Console.WriteLine("Multiplication:{0}", Multiply());
            Console.ReadKey();
        }
    }
}








