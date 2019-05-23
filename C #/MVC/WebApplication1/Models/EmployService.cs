using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployService
    {
        private static List<Employ> EmployList = null;

        static EmployService()
        {
            EmployList = new List<Employ>();
            EmployList.Add(new Employ { Empno = 101, name = "Bhargav", Dept = "JAVA", Desig = "Developer", Basic = 12345 });
            EmployList.Add(new Employ { Empno = 102, name = "Krishna", Dept = "Dotnet", Desig = "Tester", Basic = 15698 });
            EmployList.Add(new Employ { Empno = 103, name = "Arun", Dept = "SQL", Desig = "Trainer", Basic = 98562 });
            EmployList.Add(new Employ { Empno = 104, name = "Siva", Dept = "Dotnet", Desig = "Tester", Basic = 98462 });

        }
        public bool AddEmploy(Employ newEmploy)
        {
            bool EmpAdded = false;
            int oldcount = EmployList.Count;
            EmployList.Add(newEmploy);
            int newCount = EmployList.Count;
            if (newCount > oldcount)
                EmpAdded = true;
            return EmpAdded;
        }
        public List<Employ> GetAllEmploys()
        {
            return EmployList;
        }
        public Employ ShowEmploy(int employNo)
        {
            return EmployList.First(e => e.Empno == employNo);
        }
        public Employ UpdateEmploy(Employ updateEmploy)
        {
            Employ employ = EmployList.First(e => e.Empno == updateEmploy.Empno);
            employ.name = updateEmploy.name;
            employ.Dept = updateEmploy.Dept;
            employ.Desig = updateEmploy.Desig;
            employ.Basic = updateEmploy.Basic;
            return employ;
        }
        public bool RemoveEmploy(int no)
        {
            Employ employ = EmployList.First(e => e.Empno == no);
            return EmployList.Remove(employ);
        }
    }
}
        




        
