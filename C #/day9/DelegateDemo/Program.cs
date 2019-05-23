using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {
        public delegate void Hello();
        public static void Login()
        {
            Console.WriteLine(  "everyone login at 9"); 
        }
        static void Main(string[] args)
        {
            Hello obj = new Hello(Login);
            obj();
        }
    }
}
