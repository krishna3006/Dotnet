using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empexception
{
    class Emp
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public double Basic { get; set; }
    }
    class Program
    {
        public void Show()
        {
            Emp e = null;
            try
            {
                e.Empno = 1;
                e.Name = "Bhargav";
                e.Basic = 85265;
            }
            catch (Exception e1)
            {


            }
        }

        static void Main(string[] args)
        {
            new Program().Show();
        }
    }
}

