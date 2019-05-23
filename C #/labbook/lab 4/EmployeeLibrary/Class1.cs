using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeLibrary
{

    public class Employee
    {
        private string empName, empAddress, empCity, empDepartment;
        public int empSalary;
        private int empId;
        public virtual void setEmployee(int id, string name, string address, string city, string department, int salary)
        {
            empId = id;
            empName = name;
            empAddress = address;
            empCity = city;
            empDepartment = department;
            empSalary = salary;
        }
        public virtual void getSalary()
        {
            Console.WriteLine("Salary of the employee : {0}", empSalary);
        }

    }
    public class ContractEmployee : Employee
    {
        public string perks;
        public override void setEmployee(int id, string name, string address, string city, string department, int salary)
        {
            base.setEmployee(id, name, address, city, department, salary);
            perks = "Lunch";
        }
        public override void getSalary()
        {
            Console.WriteLine("Salary is {0}", empSalary + "+" + perks);
        }
    }
    public class PermanentEmployee : Employee
    {
        int NoOfLeaves;
        int ProvidendFund;
        public override void setEmployee(int id, string name, string address, string city, string department, int salary)
        {
            base.setEmployee(id, name, address, city, department, salary);
            ProvidendFund = 1500;
        }
        public override void getSalary()
        {
            Console.WriteLine("Salary is : {0}", empSalary - ProvidendFund);
        }
    }

}

