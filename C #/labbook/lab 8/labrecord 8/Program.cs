using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace labrecordday8
{
    class program2
    {
        static void Main()
        {
            Hashtable hs = GetHashtable();
            Console.WriteLine(hs.ContainsKey("Perimeter"));
            Console.WriteLine(hs.Contains("Area"));
            int value = (int)hs["Area"];
            Console.WriteLine(value);
            hs.Remove("Mortgage");
            Console.WriteLine("the count is {0}", hs.Count);
            Console.ReadKey();


        }
        static Hashtable GetHashtable()
        {
            // Create and return new Hashtable.
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Area", 1000);
            hashtable.Add("Perimeter", 55);
            hashtable.Add("Mortgage", 540);
            return hashtable;


        }

    }
}


