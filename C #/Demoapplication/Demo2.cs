using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoapplication
{
    class Demo2
    {
        public void Display(string name)
        {
            Console.WriteLine($"Name is {name}");
        }
            public void Show()
        {
            Console.WriteLine("Welcome to Dotnet..");
        }
        static void Main(String[] args)
        {
            string name = "Bhargav";
            Demo2 obj = new Demo2();
            obj.Show();
            obj.Display(name);
        }
    }
}
