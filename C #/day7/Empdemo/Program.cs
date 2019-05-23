using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Empdemo
{
    class Student
    {
        public int Sno { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Cgp { get; set; }

    }
    class Emp
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public double Basic { get; set; }
    }
    class Program
    {
        public static IEnumerable ShowEmp()
        {
            List<Emp> lstNames = new List<Emp>()
            {
                new Emp{Empno=1,Name="Bhargav",Basic=25652},
                new Emp{Empno=3,Name="Arun",Basic=56456},
                new Emp{Empno=4,Name="Siva",Basic=65000}
            };
            foreach (Emp e in lstNames)
            {
                yield return e;
            }
        }
            public static IEnumerable ShowNames()
            {
                List<string> lstNames = new List<string>()
            {
                "Kiran","Bhargav","Siva","Arun"
            };
                foreach (string s in lstNames)
                {
                    yield return s;
                }
            }

            public static IEnumerable Show()
            {
                int[] a = new int[] { 1, 2, 3, 4, 5 };
                foreach (int i in a)
                {
                    yield return i;
                }
            }
            static void Main(string[] args)
            {
                foreach (int i in Show())
                {
                    Console.WriteLine(i);
                }

                foreach (string s in ShowNames())
                {
                    Console.WriteLine(s);
                {
                    foreach(Emp e in ShowEmp())
                    {
                        Console.WriteLine(e.Empno+" "+e.Name+" "+e.Basic);
                    }
                }
                }
            }
        }
    }

