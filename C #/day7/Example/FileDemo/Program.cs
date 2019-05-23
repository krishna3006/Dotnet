using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileDemo
{
    class Program
    {
        public void CreateFile()
        {
            FileStream fs = new FileStream(@"c:\files\Hello.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Welcome to C# files");
            sw.WriteLine("First progrm in files...thank you");
            sw.Close();
            fs.Close();
            
        }
        static void Main(string[] args)
        {
            new Program().CreateFile();
        }
    }
}
