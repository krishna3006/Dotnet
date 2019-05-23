using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Student
    {
        public int StudentNo { get; set; }
        public string StudentName { get; set; }

        public Student()
        {
            StudentNo = 0;
            StudentName = string.Empty;
        }
        public Student(int employeeId, string name)
        {
            this.StudentNo = StudentNo;
            this.StudentName = name;
        }
    }
}
