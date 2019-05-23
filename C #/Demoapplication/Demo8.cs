using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoapplication
{
    class Demo8
    {
        public void Check(int n)
        {
            if (n >= 0)
            {
                Console.WriteLine("Positive No");
            }
            else
            {
                Console.WriteLine("Negative No");
            }
        }
        static void Main(String[] args)
        {
            int n;
            Console.WriteLine("enter n value");
            n = Convert.ToInt32(Console.ReadLine());
            Demo8 obj= new Demo8();
            obj.Check(n);
        }

    }
}
