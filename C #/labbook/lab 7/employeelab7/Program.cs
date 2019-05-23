using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLab7;
namespace LabRecordDay7
{
    public class EmployeeManager
    {
        public List<Employee> empList;
        public EmployeeManager()
        {
            empList = new List<Employee>();
        }
        public void AddEmployee(Employee empObj)
        {


            empList.Add(empObj);
        }
        public void Search(int id)
        {
            Employee emp = empList.Find(em => em.EmployeeId == id);
            Console.WriteLine("Id:{0}\nName:{1}\nGender:{2}\nSalary:{4}\n",
            emp.EmployeeId, emp.Name, emp.Gender, emp.Salary);
        }
        public void Display()
        {
            empList = new List<Employee>();
            foreach (Employee emp in empList)
            {
                Console.WriteLine("Id:{0}\nName:{1}\nGender:{2}\nSalary:{3}\n", emp.EmployeeId, emp.Name, emp.Gender, emp.Salary);
            }
        }
        class Program3
        {
            public static EmployeeManager em;
            static Program3()
            {
            }
            static void Main(string[] args)
            {
                try
                {
                    int choice = 0;
                    do
                    {
                        PrintMenu();
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                AddEmployee();
                                break;
                            case 2:
                                SearchEmployee();
                                break;
                            case 3:
                                Display();
                                break;
                            case 4:
                                Environment.Exit(0);
                                break;
                            default:
                                break;
                        }
                    } while (choice != 4);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
            static void Display()
            {
                em.Display();
            }
            static void SearchEmployee()
            {
                Console.WriteLine("Enter Employee Id");
                int id = int.Parse(Console.ReadLine());
                em.Search(id);
            }
            static void PrintMenu()
            {
                Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n\n{5}",
                "Welcome to Collection Debugging",
                "1. Add Employee", "2. Search Employee",
                "3. Display all Employee's",
                "4. Exit the Application.",
                "Enter your choice");
            }
            static void AddEmployee()
            {

                Console.WriteLine("Enter Employee Id");
                int Employeeid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Gender");
                char gender = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter Salary with 2 decimal points");
                double salary = double.Parse(Console.ReadLine());
                Employee emp = new Employee { EmployeeId = Employeeid, Name = name, Gender = gender, Salary = salary };
                em.AddEmployee(emp);
                Console.WriteLine("Employee Added\n");
            }
        }
    }
}


