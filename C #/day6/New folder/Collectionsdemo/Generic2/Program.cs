using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic2
{
    class Program
    {
        public void Show()
        {
            List<string> alist = new List<string>();
            alist.Add("BHargav");
            alist.Add("Arun");
            alist.Add("Siva");
            foreach (string s in alist)
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
