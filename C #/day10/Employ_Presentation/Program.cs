using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpEntity;
using Employ_BLL;
using Emp_Exceptions;
using Emp_DAL;


namespace Employ_Presentation
{
    class Program
    {
        static EmployValidation objValidation;
        public static void PrintMenu()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Employee Management syatem Menu");
            Console.WriteLine("Press 1 to Add new employee");
            Console.WriteLine("Press 2 to display all employees");
            Console.WriteLine("Press 3 to search employees");
            Console.WriteLine("Press 4 to delete employees");
            Console.WriteLine("Press 5 to update employee");
            Console.WriteLine("Press 6 to exit");
            Console.WriteLine("Press 7 to );
            Console.WriteLine("============================");
        }
        public static void DeleteEmploy()
        {
            try
            {
                Console.WriteLine("Enter employno to delete");
                int empno = Convert.ToInt32(Console.ReadLine());
                if (objValidation.DeleteEmployBLL(empno))
                {
                    Console.WriteLine("Employ deleted...");
                }
            }
            catch (EmployException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void UpdateEmploy()
        {
            try
            {
                Employ emp = new Employ();
                Console.WriteLine("Enter employee id to be updated");
                emp.Empno = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee name");
                emp.Name = Console.ReadLine();
                Console.WriteLine("Enter emloyee department:");
                emp.Dept = Console.ReadLine();
                Console.WriteLine("Enter employee salary");
                emp.Salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Emter employee doj");
                emp.Doj = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee designation");
                emp.Desig = Console.ReadLine();
                Console.WriteLine("enter mobile");
                emp.Mobile = Console.ReadLine();
                if (objValidation.UpdateEmployBLL(emp))
                {
                    Console.WriteLine("Employ updated...");
                }
            }

            catch (EmployException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Displayemploy()
        {
            try
            {
                objValidation = new EmployValidation();
                List<Employ> empList = objValidation.DisplayEmployBLL();
                Console.WriteLine("List of Employees");
                foreach (Employ e in empList)
                {
                    Console.WriteLine("Empno" + e.Empno);
                    Console.WriteLine("Name" + e.Name);
                    Console.WriteLine("Dept" + e.Dept);
                    Console.WriteLine("Salary" + e.Salary);
                    Console.WriteLine("Mobile" + e.Mobile);
                    Console.WriteLine("Desig" + e.Desig);
                    Console.WriteLine("Gender" + e.Gender);
                }
            }



            catch (EmployException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public static void SearchEmploy()
        {
            try
            {
                Employ empSearch = null;
                objValidation = new EmployValidation();
                int empno;
                Console.WriteLine("enter employ no");
                empno = Convert.ToInt32(Console.ReadLine());
                empSearch = objValidation.SearchEmployBLL(empno);
                if (empSearch != null)
                {
                    Console.WriteLine("Name" + empSearch.Name);
                    Console.WriteLine("Mobile" + empSearch.Mobile);
                    Console.WriteLine("Department" + empSearch.Dept);
                    Console.WriteLine("Designation" + empSearch.Desig);
                    Console.WriteLine("Salary" + empSearch.Salary);
                    Console.WriteLine("Mobile" + empSearch.Mobile);
                }

            }
            catch (EmployException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void AddEmploy()
        {
            try
            {
                objValidation = new EmployValidation();
                Employ newEmploy = new Employ();
                Console.WriteLine("Enter Employ no");
                newEmploy.Empno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter emp name");
                newEmploy.Name = Console.ReadLine();
                Console.WriteLine("Enter Emp name");
                newEmploy.Dept = Console.ReadLine();
                Console.WriteLine("Enter Department");
                newEmploy.Desig = Console.ReadLine();
                Console.WriteLine("Enter Designation");
                Console.WriteLine("Enter Salary");
                newEmploy.Salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Gender");
                newEmploy.Gender = Console.ReadLine();
                newEmploy.Doj = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter dateof joinngs");
                newEmploy.Mobile = Console.ReadLine();
                Console.WriteLine("Enter Mobile");
                if (objValidation.ValidateEmploy(newEmploy))
                {
                    objValidation.AddEmployBLL(newEmploy);
                    Console.WriteLine(" Employ Record Added Successfully");
                }


            }
            catch (EmployException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            byte choice;
            do
            {
                PrintMenu();
                Console.WriteLine("Enter Your Choice:");
                bool chkChoice;

                chkChoice = byte.TryParse(Console.ReadLine(), out choice);
                if (!chkChoice) { Console.WriteLine("Invalid Input "); }
                switch (choice)
                {
                    case 1:
                        AddEmploy();
                        break;
                    case 2:
                        Displayemploy();
                        break;
                    case 3:
                        SearchEmploy();
                        break;
                    case 4:
                        DeleteEmploy();
                        break;
                    case 5:
                        UpdateEmploy();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 6);

            Console.ReadKey();
        }
    }
}


      