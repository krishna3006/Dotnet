using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritencemethod
{
    class C1
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
    class C2 : C1
    {
        public void Sum(int x, int y)
        {
            int c = x + y;
            Console.WriteLine("Sum is" + c);
        }
    }
}
    static void Main(string[] args)
        {
        C1 obj=new C2();
    obj.s
        }
    }

