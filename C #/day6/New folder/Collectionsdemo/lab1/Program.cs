using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCprivateLibrary
{
    public class employee
    {
        private string ename, Address, City, Department;
        private int salary;
        private double employeeid;
        public void SetDetails(string ename, string Address, string City, string Department, int salary, double employeeid)
        {
            this.ename = ename;
            this.Address = Address;
            this.City = City;
            this.Department = Department;
            this.salary = salary;
            this.employeeid = employeeid;
        }
        public void GetDetails()
        {
            Console.WriteLine("ename={0}, Address={1}, City={2},Department ={3}, salary={4}, employeeid ={5}", this.ename, this.Address, this.City, this.Department, this.salary, this.employeeid);
        }

    }
}





