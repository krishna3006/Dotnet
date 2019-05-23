using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paramexample
{
    class Demo
    {
        public void Attendance(params string[] names)
        {
            foreach (string s in names)
            {
                Console.Write(s + " ");
            }
        }
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.Attendance();
            obj.Attendance("Arun", "Shiva");
            obj.Attendance("Arun", "Shiva", "Bhargav");
        }
    }
}
