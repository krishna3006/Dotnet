using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDEmo
{
    class First
    {
        public void Show()
        {
            Console.WriteLine("Show method from class first...");
        }
    }
        class Second : First
        {
            public void Display()
            {
                Console.WriteLine("display method from class second");
            }
        }

    class Program
    {
        static void Main(string[] args)
        {
           First obj1=new Second();
            obj1.Show();
           //Second obj2=new First();
        }

    }
}
    
