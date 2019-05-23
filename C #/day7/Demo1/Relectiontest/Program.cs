using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace Relectiontest
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(System.Data.SqlClient.SqlConnection);
           
            foreach (FieldInfo f in t.GetFields())
            {
                Console.WriteLine(f.Name + " " + f.GetValue(null));
            }
            foreach(MethodInfo e in t.GetMethods())
            {
                Console.WriteLine("Methdods" + e.Name);
            }
            
        }
    }
}
