using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Customerdemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsCustomerdemo.Customer obj = new ClsCustomerdemo.Customer();
            Type t = typeof(ClsCustomerdemo.Customer);
            FieldInfo f = t.GetField("custname");
            f.SetValue(obj,"Bhargav");
            Console.WriteLine("Name is"+f.GetValue(obj));
            FieldInfo id = t.GetField("custid");
            f.SetValue(obj, "12345");
            Console.WriteLine("custid is" + f.GetValue(obj));
            FieldInfo p = t.GetField("Premium");
            f.SetValue(obj, "50000");
            Console.WriteLine("Premium is" + f.GetValue(obj));
            FieldInfo c = t.GetField("city");
            f.SetValue(obj, "Bangalore");
            Console.WriteLine("City is" + f.GetValue(obj));
            MethodInfo e = t.GetMethod("Hello");
            e.Invoke(obj, null);
            MethodInfo i = t.GetMethod("Lunch");
            e.Invoke(obj, null);
            MethodInfo o = t.GetMethod("Logout");
            e.Invoke(obj, null);
        }
    }
}
