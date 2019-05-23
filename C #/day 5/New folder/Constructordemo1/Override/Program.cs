using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    abstract class Training
    {

        public abstract void Name();
        public abstract void Email();
    }
    class Bhargav : Training
    {
        public override void Name()
        {
            Console.WriteLine("Hi i am bhargav");
        }
        public override void Email()
        {
            Console.WriteLine("Email is bhargav.palla@capgemini.com");
        }
    }

    class Krishna : Training
    {
        public override void Name()
        {
            Console.WriteLine("Name is Krishna...");
        }
        public override void Email()
        {
            Console.WriteLine("Emai is krishna@gmail.com");
        }
        class Naga : Training
        {
            public override void Name()
            {
                Console.WriteLine("Name is naga...");
            }
            public override void Email()

            {
                Console.WriteLine("Email is naga@gmail.com");
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
               // Training obj1 = new Bhargav();
               // Training obj2 = new Krishna();
                //Training obj3 = new Naga();
                Training[] arr = new Training[]
                {
                    new Bhargav(),
                    new Krishna(),
                    new Naga()
                    };
                foreach (Training t in arr)
                {
                    t.Name();
                    t.Email();
                }
            }
        }
    }
}
