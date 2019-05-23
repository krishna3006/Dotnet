using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityModule;

namespace Lab33
{
    class OutofBound : Exception
    {
        public OutofBound(string err) : base(err)
        {

        }
    }
    class Program
    {
        public void Check(ref double x, ref double y, ref double z)
        {

            if ((x > 100) || (y > 100) || (z > 100))
            {

                x = 0;
                y = 0;
                z = 0;
                throw new OutofBound("enter above 100");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("id,name,foundation marks,webasics marks,dotnet marks");
            int i = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            double m1 = Convert.ToDouble(Console.ReadLine());
            double m2 = Convert.ToDouble(Console.ReadLine());
            double m3 = Convert.ToDouble(Console.ReadLine());
            try
            {
                new Program().Check(ref m1, ref m2, ref m3);
            }
            catch (OutofBound o)
            {

                Console.WriteLine(o.Message);
            }

            Participants p = new Participants(i, name, m1, m2, m3);
            p.ObtainedMarks(m1, m2, m3);
            Console.WriteLine("percentage is " + p.Percentage(m1, m2, m3));


        }
    }
}


