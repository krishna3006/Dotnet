using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abseg
{
    abstract class Animal
    {
        public abstract void Name();
        public abstract void Type();
    }
    class Lion : Animal
    {
        public override void Name()
        {
            Console.WriteLine("Name is Lion");
        }
        public override void Type()
        {
            Console.WriteLine("Its wild animal");
        }
    }
    class Crocodile : Animal
    {
        public override void Name()
        {
            Console.WriteLine("Name is Crocodile");
        }
        public override void Type()
        {
            Console.WriteLine("Its a animal");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Animal.obj1=new Lion();
            //Animal.obj2=new Crocodile();
            Animal[] arr = new Animal[]
            {
                new Lion(),
            new Crocodile()
            };
            foreach(Animal t in arr)
            {
                t.Name();
                t.Type();
            }
        }
    }
}
