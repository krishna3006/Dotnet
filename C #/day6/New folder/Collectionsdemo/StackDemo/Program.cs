using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
        public void Show()
        {
            Stack obj = new Stack();
            obj.Push("Bhargav");
            obj.Push("Anu");
            obj.Push("Krishna");
            obj.Push("Siva");
            Console.WriteLine("STack list");
            foreach(object ob in obj)
            {
                Console.WriteLine(ob);
            }
            obj.Pop();
            obj.Pop();
            Console.WriteLine("STack after POP");
            foreach (object ob in obj)
            {
                Console.WriteLine(ob);
            }            

        }
        static void Main(string[] args)
        {
            new Program().Show();
        }
    }
}
