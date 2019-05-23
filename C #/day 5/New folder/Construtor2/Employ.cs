using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor2
{
    class Employ
    {
        int empno;
        string name;
        double basic;
        
        public Employ()
        {
            this.empno = 1;
            this.name = "Bhargav";
            this.basic = 25000;
        }
        public Employ(int empno,string name, double basic)
        {
            this.empno = empno;
            this.name = name;
            this.basic = basic;
        }
        public void Show()
        {
            Console.WriteLine($"Empno{empno} Name{name} Basic{basic}");
        }
        ~Employ()
        {
            Console.WriteLine("Destructor...");
        }
        static void Main(string[] args)
        {
            Employ e = new Employ();
            e.Show();//calls default constructor
            Employ obj1 = new Employ(12,"Krishna",25465);
            obj1.Show();//calls the overloaded constuctor
        }
    }
}
