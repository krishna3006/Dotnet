using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQBasicsDemo
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

        public Employee()
        {
            EmployeeID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Title = string.Empty;
            DOB = DateTime.Now;
            DOJ = DateTime.Now;
        }
    }
}
