using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
     
        public class Employee
        {
            public int EmployeeID { get; set; }
            public string Name { get; set; }
            public Employee()
            {
                EmployeeID = 0;
                Name = string.Empty;
            }
            public Employee(int employeeId,string name)
            {
                this.EmployeeID = EmployeeID;
                this.Name = name;

            }
        }
    
}
