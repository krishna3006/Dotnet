using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityframe
{
    class Program
    {
        static void Main(string[] args)
        {
            ///sqlpracticeEntities ent = new sqlpracticeEntities;
            ///EMp obj = new EMp();
            ///obj.Empno = 6653;
            ///obj.nam="Bhargav";
            ///obj.dept = "Dotnet";
            /// obj.desig = "Dev";
            ///obj.basic = 56565;
            ///ent.EMps.Add(obj);
            /// ent.SaveChanges();
            /// Console.WriteLine("Record added");

            ///sqlpracticeEntities ent = new sqlpracticeEntities();
            /// EMp e = ent.EMps.Find(1);
            ///Console.WriteLine(e.nam);
            
            sqlpracticeEntities ent = new sqlpracticeEntities();
            EMp e = ent.EMps.Find(2);
            ent.EMps.Remove(e);
            ent.SaveChanges();
            Console.WriteLine("Records deleted");
        }
    }
}
