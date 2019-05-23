using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absclass
{
    abstract class Employ
    {
        int empno;
        string name;
        double sal;

        public Employ(int empno, string name, double sal)
        {
            this.empno = empno;
            this.name = name;
            this.sal = sal;
        }
        public void Show()
        {
            Console.WriteLine("Empno" + empno + "Name" + name + "Salary" + sal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
