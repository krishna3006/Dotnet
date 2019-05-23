using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerDemo
{
    [Serializable]
    class Student
    {
        public int Sno { get; set; }
        public string Name { get; set; }
        public string city { get; set; }
        public double Cgp { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"c:\files\Student.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter form = new BinaryFormatter();
            Student s = new Student();
            s.Sno = 1;
            s.Name = "Bhargav";
            s.city = "Hyderabad";
            s.Cgp = 9.6;
            form.Serialize(fs, s);
            fs.Close();
            Console.WriteLine("OBject Created");

        }
    }
}
