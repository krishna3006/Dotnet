using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employ> lstEmploy = new List<Employ>
            {
                new Employ{Empno=1,Name="Jitu",Dept="Dotnet",Desig="Developer",Basic=26565},
                new Employ{Empno=2,Name="bhargav",Dept="Sql",Desig="Programmer",Basic=56954},
                new Employ{Empno=3,Name="Arun",Dept="Dotnet",Desig="Developer",Basic=697416},
                new Employ{Empno=4,Name="Siva",Dept="Java",Desig="Programmer",Basic=98546},
                new Employ{Empno=5,Name="Krishna",Dept="Dotnet",Desig="Expert",Basic=58971},
            };
            var result = from e in lstEmploy select e;
            Console.WriteLine("All employees");
            foreach(var v in result)
            {
                Console.WriteLine(v.Empno+" "+v.Name+" "+v.Dept+" "+v.Desig+" "+v.Basic);
            }
            var result1 = from e in lstEmploy select new { e.Empno, e.Name, e.Basic };
            Console.WriteLine("Projected Fields");
            foreach(var v in result1)
                {
                Console.WriteLine(v.Empno+""+v.Name+" "+v.Basic);
            }
            var result2 = from e in lstEmploy where e.Basic >= 50000 select e;
            Console.WriteLine("Filtered records");
            foreach(var v in result2)
            {
                Console.WriteLine(v.Empno + "" + v.Name + " " + v.Basic);
            }

        }
    }
}
