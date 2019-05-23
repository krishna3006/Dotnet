using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    interface IOne
    {
        void Name();
    }
    interface ITwo
    {
        void Name();
    }
    class Demo : IOne, ITwo
    {
        void IOne.Name()
        {
            Console.WriteLine("Name from IOne");
        }
        void ITwo.Name()
        {
            Console.WriteLine("Name from ITwo");
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            IOne obj1 = new Demo();
            IOne obj2 = new Demo();
            obj1.Name();
            obj2.Name();
        }
    }
}
