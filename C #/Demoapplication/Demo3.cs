using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoapplication
{
    class Demo3
    {
        public void Login()
        {
            Console.WriteLine("Report by 9 AM sharp");
        }
        public void Lunch()
        {
            Console.WriteLine("Lunch by 12.45 to 1.30 PM");

        }
        public void Logout()
        {
            Console.WriteLine("Logout by 6 PM");
        }
        static void Main(string[] args)
        {
            Demo3 obj = new Demo3();
            obj.Login();
            obj.Lunch();
            obj.Logout();

        }
    }
}
