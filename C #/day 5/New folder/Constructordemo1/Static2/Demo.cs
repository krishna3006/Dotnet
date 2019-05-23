using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static2
{
    class Demo
    {
        int x;
        public void Show()
        {
            x = 12;
            Console.WriteLine("X value is" +x);
        }
        static void Main(string[] args)
        {
          new Demo().Show();
        }
    }
}
