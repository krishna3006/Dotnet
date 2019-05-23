using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQBasicsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>()
           {
               new Employee{EmployeeID=1001,FirstName="Malcolm",LastName="Daruwalla",Title="Manager",DOB=DateTime.Parse("11/16/1984"),DOJ=DateTime.Parse("6/8/2011"),City="Mumbai"},
               new Employee{EmployeeID=1002,FirstName="Asdin",LastName="Dhalla",Title="AsstManager",DOB=DateTime.Parse("08/20/1984"),DOJ=DateTime.Parse("7/7/2012"),City="Mumbai"},
               new Employee{EmployeeID=1003,FirstName="Madhavi",LastName="Oza",Title="Consultant",DOB=DateTime.Parse("11/14/1987 "),DOJ=DateTime.Parse("4/12/2015"),City="Pune"},
               new Employee{EmployeeID=1004,FirstName="Saba",LastName="Shaikh",Title="SE",DOB=DateTime.Parse("6/3/1990"),DOJ=DateTime.Parse("2/2/2016"),City="Pune"},
               new Employee{EmployeeID=1005,FirstName="Nazia",LastName="Shaikh",Title="SE",DOB=DateTime.Parse("3/8/1991"),DOJ=DateTime.Parse("2/2/2016"),City="Mumbai"},
               new Employee{EmployeeID=1006,FirstName="Amit",LastName="Pathak",Title="Consultant",DOB=DateTime.Parse("11/7/1989"),DOJ=DateTime.Parse("8/8/2014"),City="Chennai"},
               new Employee{EmployeeID=1007,FirstName="Vijay",LastName="Natrajan",Title="Consultant",DOB=DateTime.Parse("12/2/1989"),DOJ=DateTime.Parse("6/1/2015"),City="Mumbai"},
               new Employee{EmployeeID=1008,FirstName="Rahul",LastName="Dubey",Title="Associate",DOB=DateTime.Parse("11/11/1993"),DOJ=DateTime.Parse("11/6/2014"),City="Chennai"},
               new Employee{EmployeeID=1009,FirstName="Suresh",LastName="Mistry",Title="Associate",DOB=DateTime.Parse("8/12/1992"),DOJ=DateTime.Parse("12/3/2014"),City="Chennai"},
               new Employee{EmployeeID=1010,FirstName="Sumit",LastName="Shah",Title="Manager",DOB=DateTime.Parse("4/12/1991"),DOJ=DateTime.Parse("1/2/2016"),City="Pune"}
           };

            var result = from e in empList select e;
            Console.WriteLine("All Employees: ");
            foreach (var v in result)
            {
                Console.WriteLine(v.EmployeeID + " " + v.FirstName + " " + v.LastName + " " + v.Title + " " + v.DOB + " " + v.DOJ + " " + v.City);
            }

            var result2 = from e in empList where e.City!="Mumbai" select e;
            Console.WriteLine("\r\nCity not Mumbai ");
            foreach (var v in result2)
            {
                Console.WriteLine(v.EmployeeID + " " + v.FirstName + " " + v.LastName + " " + v.Title + " " + v.DOB + " " + v.DOJ + " " + v.City);
            }

            var result3 = from e in empList where e.Title.Equals("AsstManager") select e;
            Console.WriteLine("\r\nTitle is AsstManager ");
            foreach (var v in result3)
            {
                Console.WriteLine(v.EmployeeID + " " + v.FirstName + " " + v.LastName + " " + v.Title + " " + v.DOB + " " + v.DOJ + " " + v.City);
            }

            var result4 = from e in empList where e.LastName.StartsWith("S") select e;
            Console.WriteLine("\r\nLast Name Starts with S");
            foreach (var v in result4)
            {
                Console.WriteLine(v.EmployeeID + " " + v.FirstName + " " + v.LastName + " " + v.Title + " " + v.DOB + " " + v.DOJ + " " + v.City);
            }

            var result5 = from e in empList where e.DOJ.Year<2015 select e;
            Console.WriteLine("\r\nDate of Joining before 1/1/2015");
            foreach (var v in result5)
            {
                Console.WriteLine(v.EmployeeID + " " + v.FirstName + " " + v.LastName + " " + v.Title + " " + v.DOB + " " + v.DOJ + " " + v.City);
            }

            var result6 = from e in empList where e.DOB.Year >= 1990 select e;
            Console.WriteLine("\r\nDate of Birth after 1/1/1990");
            foreach (var v in result6)
            {
                Console.WriteLine(v.EmployeeID + " " + v.FirstName + " " + v.LastName + " " + v.Title + " " + v.DOB + " " + v.DOJ + " " + v.City);
            }

            var result7 = from e in empList where e.Title.Equals("Consultant") || e.Title.Equals("Associate") select e;
            Console.WriteLine("\r\nDate of Birth after 1/1/1990");
            foreach (var v in result7)
            {
                Console.WriteLine(v.EmployeeID + " " + v.FirstName + " " + v.LastName + " " + v.Title + " " + v.DOB + " " + v.DOJ + " " + v.City);
            }

            var result8 = from e in empList select e;
            int count=0;
            Console.WriteLine("\r\nTotal Number of Employees: ");            
            foreach (var v in result8)
            {
                count++;
            }
            Console.WriteLine(count);

            var result9 = from e in empList where e.City.Equals("Chennai") select e;
            int count1=0;
            Console.WriteLine("\r\nTotal number of Employees in Chennai ");
            foreach (var v in result9)
            {
                count1++;
            }
            Console.WriteLine(count1);

            var empmax = empList.Max(x => x.EmployeeID);
            Console.WriteLine($"Highest Employee ID is {empmax}");

            var result12 = from e in empList where e.DOJ.Year>=2015 select e;
            int count3 = 0;
            Console.WriteLine("\r\nTotal Number of Employees who joined after 1/1/2015: ");
            foreach (var v in result12)
            {
                count3++;
            }
            Console.WriteLine(count3);

            var result13 = from e in empList where e.Title!="Associate" select e;
            int count4 = 0;
            Console.WriteLine("\r\nTotal Number of Employees: ");
            foreach (var v in result13)
            {
                count4++;
            }
            Console.WriteLine(count4);

            var result14 = empList.Select(x => x).GroupBy(x => x.City);
            foreach (var v in result14)
            {
                 int count5 = 0;
                Console.WriteLine(v.Key);
                foreach (var x in v)
                {
                    count5++;
                }
                Console.WriteLine(count5);
            }

            var result15 = empList.Select(x => x).GroupBy(x => x.City);
            foreach (var v in result15)
            {
                int mgr = 0, astmgr = 0, cons = 0, se = 0, ass = 0;
                Console.WriteLine(v.Key);
                foreach (var x in v)
                {
                    if(x.Title.Equals("Manager"))
                    {
                        mgr++;
                    }
                    else if(x.Title.Equals("AsstManager"))
                    {
                        astmgr++;
                    }
                    else if (x.Title.Equals("Consultant"))
                    {
                        cons++;
                    }
                    else if (x.Title.Equals("SE"))
                    {
                        se++;
                    }
                    else if(x.Title.Equals("Associate"))
                    {
                        ass++;
                    }
                }
                if (mgr != 0) { Console.WriteLine($"Total Number of Managers: {mgr}"); }
                if (astmgr != 0) { Console.WriteLine($"Total Number of AsstManagers: {astmgr}"); }
                if (cons != 0) { Console.WriteLine($"Total Number of Consultant: {cons}"); }
                if (se != 0) { Console.WriteLine($"Total Number of SE: {se}"); }
                if (ass != 0) { Console.WriteLine($"Total Number of Associate: {ass}"); }
            }

            var minage = empList.Min(x => x.DOB);
            var result16 = from x in empList where x.DOB== minage select x;
            foreach(var y in result16)
            {
                Console.WriteLine("Youngest Member is "+y.FirstName+" "+y.LastName);
            }            
        }
    }
}
