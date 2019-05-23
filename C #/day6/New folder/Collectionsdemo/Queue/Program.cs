using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Queueexp
{
    class Program
    {
        public void Show()
        {
            Queue obj = new Queue();
            obj.Enqueue("Bhargav");
            obj.Enqueue("Anu");
            obj.Enqueue("Krishna");
            obj.Enqueue("Siva");
            Console.WriteLine("Queue list");
            foreach (object ob in obj)
            {
                Console.WriteLine(ob);
            }
            obj.Dequeue();
            obj.Dequeue();
            Console.WriteLine("Queue  after POP");
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
