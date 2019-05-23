using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Type typeobj = typeof(ReflectionDemo.Employ);
            foreach(MethodInfo mi in typeobj.GetMethods())
            {
                Console.WriteLine("the following are the methods in test class");
                Console.WriteLine("Method{0}",mi.Name);
            }
            foreach(FieldInfo f in typeobj.GetFields())
            {
                Console.WriteLine("the following are the fields in test class");
                Console.WriteLine("Field{0}", f.Name);
            }
            foreach(ConstructorInfo c in typeobj.GetConstructors())
            {
                 Console.WriteLine("the following are the Constructors in test class");
                 Console.WriteLine("Constructor{0}", c.Name);
                }
            }
        }
    }

