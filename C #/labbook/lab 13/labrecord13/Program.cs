using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LabRecordDay13
{
    [Serializable]
    class Program
    {

        static void Main(string[] args)
        {
            // Contact con = new Contact { ContactID = 1, ContactName = "Srikar", ContactNumber = "8297578722" };
            List<Contact> list = new List<Contact>();
            list.Add(new Contact { ContactID = 1, ContactName = "Srikar", ContactNumber = "8297578722" });
            list.Add(new Contact { ContactID = 2, ContactName = "Manasa", ContactNumber = "8297" });
            FileStream file = new FileStream(@"D:\emdata.txt", FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(file, list);
            Console.WriteLine("Data has been serialized");
            file.Close();
            Console.ReadKey();
        }
    }
}
