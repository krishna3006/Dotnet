using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Example
{
    class Emp
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public double Basic { get; set; }
    }
    class Program
    { 
        public static IEnumerable ShowNames()
        {
            List<string> lstNames = new List<string>()
            {
                "Kiran","Bhargav","Siva","Arun"
            };
            foreach(string s in lstNames)
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
                foreach(int i in Show())
            {
                Console.WriteLine(i);
            }

            foreach(string s in ShowNames())
            {
                Console.WriteLine(s);
            }
            }
        }
    }

