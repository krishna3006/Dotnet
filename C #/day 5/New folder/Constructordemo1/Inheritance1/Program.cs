using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class C1
    {
        static C1()
        {
            Console.WriteLine("Static base class constructor...");
        }
        public C1()
        {
            Console.WriteLine("Base class constructor");
        }


        ~C1()
        {
            Console.WriteLine("Base class Destructor");
        }
    }
    class C2 : C1
    {
        static C2()
        {
            Console.WriteLine("Derived class static constructor...");
        }
        public C2()
        {
            Console.WriteLine("Derived Class Constructor");
        }
        ~C2()
        {
            Console.WriteLine("Derived class Destructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C2 obj = new C2();
        }
    }
}
