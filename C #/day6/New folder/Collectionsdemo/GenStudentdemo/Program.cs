using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenStudentdemo
{
    class Student
    {
        public int Sno { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public double Cgp { get; set; }
    }
        class Demo
        {
        static void Main(string[] args)
        {
            List<Student>lstStudent = new List<Student>();

            lstStudent.Add(new Student { Sno = 1 , name = "Bhargav", city = "Bangalore", Cgp = 8.6});
            lstStudent.Add(new Student { Sno = 2, name = "krishna", city = "chennai", Cgp = 8.8});
            lstStudent.Add(new Student { Sno = 3, name = "narasimha", city = "hyderabad", Cgp = 8.9});

            foreach(Student s in lstStudent)
            {
                Console.WriteLine(s.Sno+" "+s.name+" "+s.city+" "+s.Cgp);

            }
            lstStudent.Sort();

        }
    }
}
