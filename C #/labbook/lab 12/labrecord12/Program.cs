using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LabRecordDay12
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = string.Empty;
            Console.WriteLine("Enter the file to read");
            string str = Console.ReadLine();
            try
            {
                StreamReader sr = new StreamReader(@"D:\" + str);
                msg = sr.ReadToEnd();
                sr.Close();
                Console.WriteLine("The content in the given file are: ");
                Console.WriteLine(msg);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error : {0}", ex.Message);
            }

            Console.ReadKey();
        }
    }
}

