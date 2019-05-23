using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCprivateLibrary;
namespace ConAppDay3
{
    class empl1
    {
        static void Main(string[] args)
        {
            employee[] employees = new employee[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter ename : ");
                string ename = Console.ReadLine();
                Console.WriteLine("enter Address : ");
                string Address = Console.ReadLine();
                Console.WriteLine("enter City : ");
                string City = Console.ReadLine();
                Console.WriteLine("Department : ");
                string Department = Console.ReadLine();
                Console.WriteLine("enter salary : ");
                int salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter employeeid : ");
                double employeeid = Convert.ToInt64(Console.ReadLine());
                employees[i] = new employee();
                employees[i].SetDetails(ename, Address, City, Department, salary, employeeid);
                employees[i].GetDetails();
            }
            Console.ReadKey();
        }
    }
}
