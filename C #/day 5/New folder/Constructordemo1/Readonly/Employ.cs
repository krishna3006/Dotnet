using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readonly
{
    class Employ
    {
        int empno;
        string name;
        string company;
        public Employ()
        {
            this.empno = 1;
            this.name = "Bhargav";
            this.company = "Capgemini";
        }
        public int Empno
        {
            get { return empno; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Company
        {
            get { return company; }
        }
        static void Main(string[] args)
        {
            Employ e = new Employ();
            //e.Empno = 66;
            //e.Company="CG";
            //e.Name="Bhargav";
            /*will not work in readonly property*/
            Console.WriteLine(e.Empno + " " +e.Name+ " " +e.Company);
        }
    }
}
