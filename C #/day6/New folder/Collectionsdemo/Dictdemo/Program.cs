using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictdemo
{
    class Program
    {
        public void Show(int empno)
        {
            Dictionary<int, string> dicEmp = new Dictionary<int, string>();
            dicEmp.Add(1, "Arun");
            dicEmp.Add(3, "Bhargav");
            dicEmp.Add(4, "Siva");
            string res = string.Empty;
            dicEmp.TryGetValue(empno, out res);
            Console.WriteLine("Result is" +res);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employ no");
            int empno = Convert.ToInt32(Console.ReadLine());
            new Program().Show(empno);
        }
    }
}
