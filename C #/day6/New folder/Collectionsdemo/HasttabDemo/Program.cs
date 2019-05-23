using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace HasttabDemo
{
    class Program
    {
        public void Show()
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "Krishna");
            ht.Add("2", "Bhargav");
            ht.Add("3", "Naga");
            Console.WriteLine("Hashtable Data is");
            foreach(DictionaryEntry ent in ht)
            {
                Console.WriteLine(ent.Key+" "+ent.Value);
            }
        }
        static void Main(string[] args)
        {
            new Program().Show();
        }
    }
}
