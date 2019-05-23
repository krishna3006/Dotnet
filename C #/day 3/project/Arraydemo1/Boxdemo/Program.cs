using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxdemo
{
    class Program
    {
        public void Show()
        {
            int x = 12;
            double y = 12.5;
            string name = "Bhargav";

            /*Implementing Boxing*/
            object ob1 = x;
            object ob2 = y;
            object ob3 = name;

            /* Implementing unboxing*/
            int x1 = (Int32)ob1;
            double y1 = (Double)ob2;
            string n1 = (string)ob3;

            Console.WriteLine("After unboxing {x1}{y1}{n1}");
        }
        static void Main(string[] args)
        {
            new Program().Show();
        }
    }
}
