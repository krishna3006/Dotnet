using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        public void Show(int[] a)
        {
            foreach(int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
        }
    }
}
