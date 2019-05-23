using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamdadb
{
    class Program
    {
       public static void ShowEmploy()
        {
            sqlpracticeEntities entities = new sqlpracticeEntities();
            var resultEmp = entities.EMps.Select(x => x);
            Console.WriteLine("employ search");
            foreach(var v in resultEmp)
            {
                Console.WriteLine(v.Empno+" "+v.nam+" "+v.dept+" "+v.desig+" "+v.basic);
            }
        }
        public static void ShowProjected()
        {
            sqlpracticeEntities entities = new sqlpracticeEntities();
            var resultEmp = entities.EMps.Select(x=> new{ x.Empno, x.nam, x.basic });
            Console.WriteLine("Employ Records");
            foreach (var v in resultEmp)
            {
                Console.WriteLine(v.Empno+" "+v.nam+" "+v.basic);
            }

        }
        public static void SearchByID(int empno)
        {
            sqlpracticeEntities entities=new sqlpracticeEntities();
            EMp emp = entities.EMps.Where(x => x.Empno == empno).Select(x => x).FirstOrDefault();
            Console.WriteLine("Search Result \n***********************");
          if(emp!=null)
            {
                Console.WriteLine(emp.nam+" "+emp.basic+" "+emp.dept+" " + emp.desig);
            }
          else
            {
                Console.WriteLine("Records not found");
            }
        }
        public static void OrderByName()
        {
            sqlpracticeEntities entities = new sqlpracticeEntities();
            var result = entities.EMps.OrderBy(x => x.nam).Select(x => x);
            Console.WriteLine("Order by result");
            foreach(var v in result)
            {
                Console.WriteLine(v.Empno+" "+v.nam+" "+v.dept+" "+v.desig+" "+
                    v.basic);
            }
        }
        static void Main(string[] args)
        {
            ShowEmploy();
            ShowProjected();
            SearchByID(23);
            OrderByName();
        }
    }
}
