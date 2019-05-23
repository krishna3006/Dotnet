using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basedemo
{
    class C1
    {
        public void Show()
        {
            Console.WriteLine("show from class C1");
        }
    }
    class C2 : C1
    {
        public new void Show()
        {
            base.Show();
            Console.WriteLine("Show from class C2...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C2 obj = new C2();
            obj.Show();
           
        }
    }
}
