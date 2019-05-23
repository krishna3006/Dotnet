using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outref
{
    class Program
    {
        public void Show(int empno,out string name, out double sal)
        {
            if (empno == 1)
            {
                name = "Bhargav";
                sal = 25000;
            }
            else
            {
                name = "not found";
                sal = 0;
            }
        }
        static void Main(string[] args)
        {
            int empno = 1;
            double basic;
            string name;
            new Program().Show(empno, out name, out basic);
            Console.WriteLine($"Name {name} Salary {basic}");
        }
    }
}
