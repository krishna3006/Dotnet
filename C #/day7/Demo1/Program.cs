using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        public static void Show(string Firstname,string Lastname, string city, string course)
        {
            Console.WriteLine("Firstname"+Firstname);
            Console.WriteLine("Lastname"+Lastname);
            Console.WriteLine("city"+city);
            Console.WriteLine("Course"+course);

        }
        static void Main(string[] args)
        {
            Show("Hyderabad", "Dotnet", "bhargav", "krishna");
            Show(city:"Bangalore",course:"Dotnet",Lastname: "Krishna",Firstname:"Bhargav");
        }
    }
}
