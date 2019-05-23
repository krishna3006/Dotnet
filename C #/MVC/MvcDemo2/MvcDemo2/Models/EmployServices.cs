using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDemo2.Models
{
    public class EmployServices
    {
        public static List<Employ> employList = null;
        static EmployServices()
        {
            employList = new List<Employ>();
            employList.Add(new Employ { EmpNo = 1, Name = "Pawan", Dept = "Dotnet", Desig = "Analyst", Basic = 17500 });
            employList.Add(new Employ { EmpNo = 2, Name = "Kumar", Dept = "Dotnet", Desig = "Analyst", Basic = 17500 });
            employList.Add(new Employ { EmpNo = 3, Name = "Laxmi", Dept = "Dotnet", Desig = "Analyst", Basic = 17500 });
            employList.Add(new Employ { EmpNo = 4, Name = "Sai",   Dept = "Dotnet", Desig = "Analyst", Basic = 17500 });
            employList.Add(new Employ { EmpNo = 5, Name = "Mukesh", Dept = "Dotnet", Desig = "Analyst", Basic = 17500 });
        }
        public bool AddEmploy(Employ newEmploy)
        {
            bool employAdded = false;
            int oldcount = employList.Count;
            employList.Add(newEmploy);
            int newCount = employList.Count;
            if (newCount > oldcount)
                employAdded = true;
            return employAdded;
        }
        public List<Employ> GetAllEmploys()
        {
            return employList;
        }
        public Employ showEmploy(int employNumber)
        {
            return employList.First(g => g.EmpNo == employNumber);
        }
        public Employ UpdateEmploy(Employ updateEmploy)
        {
            Employ employ = employList.First(g => g.EmpNo == updateEmploy.EmpNo);
            employ.Name = updateEmploy.Name;
            employ.Dept = updateEmploy.Dept;
            employ.Desig = updateEmploy.Desig;
            employ.Basic = updateEmploy.Basic;
            return employ;
        }
        public bool RemoveEmploy(int id)
        {
            Employ gs = employList.First(g => g.EmpNo == id);
            return employList.Remove(gs);
        }
    }
}