using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverloading
{
    class Program
    {
        public void Show(int x)
        {
            Console.WriteLine("Show with Integer"+x);
        }
        public void Show(double x)
        {
            Console.WriteLine("Show with double" + x);
        }
        public void Show(string x)
        {
            Console.WriteLine("Show with String" + x);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Show(12);
            obj.Show(12.5);
            obj.Show("Bhargav");
        }
    }
}
