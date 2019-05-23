using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentarray
{
    class Student
    {
        public string firstName;
        public string lastname;
        public string city;
        public double cgp;
    }
    class Program
    {
        public void Show()
        {
            Student s1 = new Student();
            s1.firstName = "Bhargav";
            s1.lastname = "Palla";
            s1.city = "Kakinada";
            s1.cgp = 65;

            Student s2 = new Student();
            s2.firstName = "Kiran";
            s2.lastname = "Chebolu";
            s2.city = "Hyderabad";
            s2.cgp = 75;

            Student[] arr = new Student[] { s1, s2 };
            foreach(Student s in arr)
            {
                Console.WriteLine(s.firstName + " " + s.lastname + " " + s.city+" "+s.cgp);
            }
        }
        static void Main(string[] args)
        {
            new Program().Show();
        }
    }
}
