using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraydemo3
{
    class Program
    {
        public void Show()
        {
            string[] arr = new string[]
            {
                "Arun","Bhargav","Karthik","Anusha","Shiva"
            };
            Console.WriteLine("Names are");
            foreach(string s in arr)
            {
                Console.WriteLine(s);
            }
            Array.Sort(arr);
            Console.WriteLine("Sorted List");
            foreach(string s in arr)
            {
                Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
            new Program().Show();
        }
    }
}
