using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Emp> lstEmp = new List<Emp>()
            {
                new Emp{Empno=1,Name="Siddharth",Dept="Dotnet",Desig="Programmer",Basic=48843},
                new Emp{Empno=2,Name="Naveen",Dept="Java",Desig="Programmer",Basic=64444},
                new Emp{Empno=3,Name="Rajesh",Dept="Dotnet",Desig="Programmer",Basic=64433},
                new Emp{Empno=4,Name="Guru",Dept="SQL",Desig="Programmer",Basic=56777},
                new Emp{Empno=5,Name="Sai",Dept="Dynamics",Desig="TeamLead",Basic=99999}
            };

            var grpList = from e in lstEmp group e by e.Dept into empGroup select empGroup;

            foreach(var v in grpList)
            {
                Console.WriteLine(string.Format("Dep Name:{0}",v.Key));
                foreach(var x in v)
                {
                    Console.WriteLine(string.Format("\t Employee:{0}",x.Name)); 
                }

            }
            var result2 = lstEmp.Select(x => x).GroupBy(x => x.Dept);
            foreach(var v in result2)
            {
                Console.WriteLine(v.Key);
                foreach(var x in v)
                {
                    Console.WriteLine(x.Name);
                }
            }
            var empMax = lstEmp.Max(x => x.Basic);
            var empMin = lstEmp.Min(x => x.Basic);
            var avgSl = lstEmp.Average(x => x.Basic);
            Console.WriteLine("Max saalry "+empMax+"min salary"+ empMin);
            Console.WriteLine("Average "+avgSl);
            //var res1=from em in lstEmp select em;
            var res1 = lstEmp.Select(x => x);
            Console.WriteLine("result is ");
            foreach (var v in res1)
            {
                Console.WriteLine("empno" + v.Empno + "Name" + v.Name + "Dept" + v.Dept + "Desig" + v.Desig + "Basic" + v.Basic);
            }
            var res2 = lstEmp.Select(x => new { x.Empno, x.Name, x.Basic });
            Console.WriteLine("Result2 is");
            foreach (var v in res2)
            {
                Console.WriteLine("empno" + v.Empno + "Name" + v.Name + "Basic" + v.Basic);
            }
            var res3 = lstEmp.Where(x => x.Basic >= 6000).Select(x => x);
            Console.WriteLine("Filtered date");
            foreach (var v in res3)
            {
                Console.WriteLine("empno" + v.Empno + "Name" + v.Name + "Dept" + v.Dept + "Desig" + v.Desig + "Basic" + v.Basic);
            }
            var res4=lstEmp.OrderBy(x=>x.Name).Select(x => x);
            Console.WriteLine("Order by result");
            foreach(var v in res4)
            {
                Console.WriteLine("empno" + v.Empno + "Name" + v.Name + "Dept" + v.Dept + "Desig" + v.Desig + "Basic" + v.Basic);
            }
            var res5 = lstEmp.OrderByDescending(x => x.Name).Select(x => x);
            Console.WriteLine("Order by descending");
            foreach(var v in res5)
            {
                Console.WriteLine("empno" + v.Empno + "Name" + v.Name + "Dept" + v.Dept + "Desig" + v.Desig + "Basic" + v.Basic);
            }

        }
             
        
    }
}
