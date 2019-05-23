using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;
namespace LabRecordDay4
{

    class Lab4Ex1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter type of Employee : ");
            Console.WriteLine("1.Contract Employee   2.Permanent Employee ");
            Employee e;
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    e = new ContractEmployee();
                    Console.WriteLine("Enter the deatils of the employee......");
                    Console.WriteLine("Enter Id of an employee : ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter name of the employee :");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the address of the employee : ");
                    string address = Console.ReadLine();
                    Console.WriteLine("Enter the city of the meployee :");
                    string city = Console.ReadLine();
                    Console.WriteLine("Enter the department of the employeee: ");
                    string department = Console.ReadLine();
                    Console.WriteLine("Enter the salary of the employee : ");
                    int salary = Convert.ToInt32(Console.ReadLine());

                    e.setEmployee(id, name, address, city, department, salary);

                    e.getSalary();
                    break;
                case 2:
                    e = new PermanentEmployee();
                    Console.WriteLine("Enter the deatils of the employee......");
                    Console.WriteLine("Enter Id of an employee : ");
                    int id1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter name of the employee :");
                    string name1 = Console.ReadLine();
                    Console.WriteLine("Enter the address of the employee : ");
                    string address1 = Console.ReadLine();
                    Console.WriteLine("Enter the city of the meployee :");
                    string city1 = Console.ReadLine();
                    Console.WriteLine("Enter the department of the employeee: ");
                    string department1 = Console.ReadLine();
                    Console.WriteLine("Enter the salary of the employee : ");
                    int salary1 = Convert.ToInt32(Console.ReadLine());
                    e.setEmployee(id1, name1, address1, city1, department1, salary1);
                    e.getSalary();
                    break;
                default:
                    return;
            }
            Console.ReadKey();
        }
    }
}
