using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class Program
    {
        public delegate void Demo();
        public static void Login()
        {
            Console.WriteLine("login at 9");
        }
        public static void Lunch()
        {
            Console.WriteLine("lunch at 1");
        }
        public static void Logout()
        {
            Console.WriteLine("Logut at 6");
        }

      
        static void Main(string[] args)
        {
        Demo obj = new Demo(Login);
            obj += new Demo(Lunch);
            obj += new Demo(Logout);
            obj();
            Console.WriteLine("Delegate after Minus");
            obj -= new Demo(Lunch);
            obj();
        }
    }
}
