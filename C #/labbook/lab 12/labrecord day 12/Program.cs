using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LabRecordDay12
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter souce file name :");
            string source = Console.ReadLine();
            Console.WriteLine("Enter destination file name");
            string destination = Console.ReadLine();
            StreamReader sr = new StreamReader(@"D:\" + source);
            string msg = sr.ReadToEnd();
            StreamWriter sw = new StreamWriter(@"D:\" + destination, true);
            sw.WriteLine(msg);
            sr.Close();
            sw.Close();
            Console.WriteLine("Successfull");
            Console.ReadKey();
        }
    }
}

