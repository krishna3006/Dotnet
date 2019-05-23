using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsStudent
{
    public class Student
    {
        public string fname;
        public string Iname;
        public string city;
        public int Sno { get; set; }
        public int Course { get; set; }
        public double Cgp { get; set; }
    }
    public Student()
    {
        Sno = 1;
        Course = "Dotnet";
        Cgp = 63;
    }
        public Student(string fname,string Iname,string city)
        {
            this.fname = fname;
            this.Iname = Iname;
            this.city = city;
        }
    }
    public void Show()
    {
        Console.WriteLine("Sno"+Sno+"Course"+Course+"Cgp"+Cgp);
    }

