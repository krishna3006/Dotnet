using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employ2
{
    class Employ
    {
        private static Employ obj3;

        public int Empno { get; set; }
        public string name { get; set; }
        public double Basic { get; set; }
        public string Company { get; set; } = "Capgemini";
        public override bool Equals(object obj)
        {
            Employ e = (Employ)obj;
            if (e.Basic == Basic)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Employ obj = new Employ();
                obj.Empno = 1;
                obj.name = "Bhargav";
                obj.Basic = 25000;
                Console.WriteLine("Empno" + obj.Empno + "Name" + obj.name + "sal" + obj.Basic);
                Console.WriteLine("Compamy" + obj.Company);
                Employ obj2 = obj;
                Employ.obj3 = new Employ();
                obj3.Empno = 5;
                obj3.name = "Krishna";
                obj3.Basic = 25321;
                Console.WriteLine(obj2 == obj);
                Console.WriteLine(obj2.Equals(obj));
                Console.WriteLine(obj3 == obj2);
                Console.WriteLine(obj3.Equals(obj2));
            }
        }

    }
}
