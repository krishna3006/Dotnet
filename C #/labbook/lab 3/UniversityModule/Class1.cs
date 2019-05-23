using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModule
{
    public class Participants
    {
        static string companyName;
        private int empId;
        private string name;
        private double foundationMark;
        private double webmarks;
        private double dotnetmarks;
        public int totalMarks = 300;
        public Participants()
        {
            empId = 0;
            name = null;
            foundationMark = 0;
            webmarks = 0;
            dotnetmarks = 0;
            companyName = null;


        }
        static Participants()
        {
            companyName = "Corparate University";
        }
        public Participants(int id, string name, double fmarks, double wmarks, double dmarks)
        {
            this.empId = id;
            this.name = name;
            this.foundationMark = fmarks;
            this.webmarks = wmarks;
            this.dotnetmarks = dmarks;

        }
        public void ObtainedMarks(double x, double y, double z)
        {
            Console.WriteLine("ObtainedMarks marks are" + (x + y + z));
        }
        public double Percentage(double x, double y, double z)
        {

            return ((x + y + z) / 300) * 100;
        }

    }
}

