using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxemploy
{
    class Employ
    {
        public int empno;
        public string name;
        public double basic;
    }
    class Demo
    {
        public void Show(object ob)
        {
            //casting object to Employ
            //string x=(String)ob;
            Employ x = (Employ)ob;
            Console.WriteLine("Empno{0} Name{1} Sal{2}", x.empno, x.name, x.basic);
        }

    }
}
        static void Main(string[] args)
        {
        Employ e = new Employ();
        e.empno = 1;
        e.name = "Bhargav";
        e.basic = 56000;
        new Program().Show(e);
        }
    }
}
