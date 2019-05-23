using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptDemo
{
    class Program
    {
        public void Show(string company, string course="Dotnet")
        {
            Console.WriteLine($"Company{company} Course{course}");
        }
        public void Venue(string city, string venue = "capgemini")
        {
            Console.WriteLine($"City{city} Venue{venue}");
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Show("capgemini");
            obj.Venue("Hyderabad");
            obj.Show("capgemini", "Javascript");
            obj.Venue("Hyderabad", "CG");
        }
    }
}
