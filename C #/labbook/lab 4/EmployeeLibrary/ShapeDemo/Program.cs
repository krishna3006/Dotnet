using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
    public class Shape
    {
        public virtual void WhoamI()
        {
            Console.WriteLine("I m Shape");
        }
    }
    class Triangle : Shape
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
    class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Triangle();
            s.WhoamI();
            s = new Circle();
            s.WhoamI();
            Console.ReadKey();
        }
    }
}
