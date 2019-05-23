using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Serialisation
{
    [Serializable]
    class Employ
    {
        public int Empno { get; set; }
        public String Name { get; set; }
        public int Basic { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"c:\files\Emp.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter form = new BinaryFormatter();
            Employ e = new Employ();
            e.Empno = 1;
            e.Name = "Bhargav";
            e.Basic = 56333;
            form.Serialize(fs, e);
            fs.Close();
        }
    }
}
