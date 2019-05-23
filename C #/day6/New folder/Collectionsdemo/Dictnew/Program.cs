using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictnew
{
    class Program
    {
        public void Check(string name)
        {
            Dictionary<string, double> emp0ict = new Dictionary<string, double>();
            emp0ict["arun"] = 656565.26;
            emp0ict["Bhargav"] = 56865.88;
            emp0ict["siva"]= 26556.56;
            double res = 0;
            emp0ict.TryGetValue(name, out res);
            Console.WriteLine("Result is" +res);
        }
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            new Program().Check(name);
         
        }
    }
}
