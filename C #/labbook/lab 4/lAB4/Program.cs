using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class Shape
    {
        public virtual void WhoamI()
        {
            Console.WriteLine("I m Shape");
        }
    }
    public class Triangle : Shape
    {
        public override void WhoamI()
        {
            Console.WriteLine("I m Triangle");

        }

    }
    public class Circle : Shape
    {
        public override void WhoamI()
        {
            Console.WriteLine("I m Circle");
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {

            Shape s = new Triangle();
            s.WhoamI();
            Shape s1 = new Circle();
            s1.WhoamI();
            Console.ReadKey();
        }
    }
}
