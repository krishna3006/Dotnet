using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace LabRecodDay9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();


            list.Add("srikar", ".Net");
            list.Add("pavan", "Java");
            list.Add("satya", "C");
            list.Add("Akshay", "Java");
            list.Add("hemanth", "C++");
            // list.Add("srikar", "VB");
            Console.WriteLine("Thh Given List is:");
            foreach (KeyValuePair<string, string> item in list)
            {

                Console.WriteLine("{0} , {1}", item.Key, item.Value);
            }


            list.Remove("satya");
            Console.WriteLine();
            Console.WriteLine("After removing a key,value pair,The list is");
            Console.WriteLine();
            foreach (KeyValuePair<string, string> item in list)
            {

                Console.WriteLine("{0} , {1}", item.Key, item.Value);
            }
            Console.WriteLine();
            Console.WriteLine("After Replacing");
            Console.WriteLine();
            list["srikar"] = "Java";

            foreach (KeyValuePair<string, string> item in list)
            {

                Console.WriteLine("{0} , {1}", item.Key, item.Value);
            }
            Console.WriteLine();
            Console.WriteLine("For Searching");
            Console.WriteLine("Enter a key to search: ");
            string key = Console.ReadLine();
            try
            {
                Console.WriteLine(list[key]);
                Console.WriteLine("Key and value Found");
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine("Error\n{0}", ex.Message);

            }
            Console.ReadKey();
        }
    }
}
