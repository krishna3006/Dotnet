using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Collectionsdemo
{
    class Program
    {
        public void Show()
        {
            ArrayList alist = new ArrayList();
            alist.Add("Bhargav");
            alist.Add("Krishna");
            alist.Add("ARun");
            alist.Add("Siva");
            Console.WriteLine("Element are");
            foreach(object ob in alist)
            {
                Console.WriteLine(ob);
            }
            alist.Insert(2, "Naga");
            Console.WriteLine("List after adding the element");
            foreach (object ob in alist)
            {
                Console.WriteLine(ob);
            }
            alist.RemoveAt(2);
            Console.WriteLine("List by removing by object index");
            foreach(object ob in alist)
            {
                Console.WriteLine(ob);
            }
            alist.Add("sameer");
            alist.Add("Yamini");
            alist.Add("Anusha");
            alist.Sort();
            Console.WriteLine("sorted List");
            foreach(object ob in alist)
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
