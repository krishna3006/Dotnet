using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extdemo
{
    /// <summary>
    /// Extension Methods
    /// </summary>
    static class ExtDemo
    {
        public static int Sum(this int p,int x,int y)
        {
            return x + y;
        }
        public static string Lunch(this int s)
        {
            return "Lunch by 2PM";
        }
        public static string SayHello(this string s)
        {
            return "Welcome to Extension Methods...";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Welcome";
            Console.WriteLine(s);
            Console.WriteLine(s.SayHello());
            int i = 12;
            Console.WriteLine(i.Lunch());
            Console.WriteLine(i.Sum(25,36));

            
        }
    }
}
