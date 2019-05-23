using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propdemo1
{
    class student
    {
        private int sno;
        public int Sno
        {
            get
            {
                return sno;
            }
            set
            {
                sno = value;

            }
        }
        static void Main(string[] args)
        {
            student obj = new student();
            obj.Sno = 1;
            Console.WriteLine("Sno is+");
        }
    }
}
