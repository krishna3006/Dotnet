using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionDemo
{
    public class Employ
    {
        public string city;
        public string course;
        public string modulename;

        public int Empno { get; set; }
        public string name { get; set; }
        public double Basic { get; set; }

        public Employ()
        {
            Empno = 1;
            name = "Bhargav";
            Basic = 66955;
        }
        public Employ(string city,string course, string modulename)
        {
            this.city = city;
            this.course = course;
            this.modulename = modulename;
        }
        public void Show()
        {
            Console.WriteLine("Empno"+Empno+"name"+name+"Basic"+Basic);
        }
    }
}
