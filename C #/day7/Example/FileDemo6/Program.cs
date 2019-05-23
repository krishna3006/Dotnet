using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileDemo6
{
    class Program
    {
        public void ShowFile(string file)
        {
            FileStream fs=new FileStream (file, FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str;
            while((str=sr.ReadLine())!=null)
                {
                Console.WriteLine(str);
            }
        }
        static void Main(string[] args)
        {
            string file;
            Console.WriteLine("enter filename with path");
            file = Console.ReadLine();
            new Program().ShowFile(file);
        }
    }
}
