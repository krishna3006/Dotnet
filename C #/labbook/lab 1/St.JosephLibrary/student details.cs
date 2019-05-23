using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.JosephLibrary
{
    public class StudentDet
    {
        private int rollNumber;
        private string studentName, address;
        private float percentage;
        private char gender;
        private DateTime dateOfBirth;
        private byte age;
        public void setDetails()
        {
            Console.Write("Enter Rool Number : ");
            rollNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Name : ");
            studentName = Console.ReadLine();
            Console.Write("Enter Student Age : ");
            age = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter Gender : ");
            gender = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter DateOfBirth MM/DD/YYYY : ");
            dateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter Address : ");
            address = Console.ReadLine();
            Console.Write("Enter Percentage : ");
            percentage = Convert.ToSingle(Console.ReadLine());

        }
        public void GetDetails()
        {
            Console.WriteLine("Rool number is : {0}\n", rollNumber);
            Console.WriteLine("stident Name is : {0}\n", studentName);
            Console.WriteLine("Student Age is : {0}\n", age);
            Console.WriteLine("Gender is : {0}\n", gender);
            Console.WriteLine("DateOfBarth is : {0}\n", dateOfBirth);
            Console.WriteLine("Address is : {0}\n", address);
            Console.WriteLine("Percentage is : {0}\n", percentage);
        }
    }
        namespace ConAppDay4
    {
        class stud
        {
            static void Main(string[] args)
            {
                StudentDet sd = new StudentDet();
                sd.setDetails();
                sd.GetDetails();
                Console.ReadKey();
            }
        }
    }

}


