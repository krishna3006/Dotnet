using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRecordDay7
{
    class Contact
    {
        public int ContactNo { get; set; }
        public string ContactName { get; set; }
        public string CellNo { get; set; }
    }

    class Program
    {
        public static void AddContact(List<Contact> list)
        {
            Console.WriteLine("Enter the Contact number");
            int contact = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter contact name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Cell number");
            string cell = Console.ReadLine();
            list.Add(new Contact { ContactNo = contact, ContactName = name, CellNo = cell });
            Console.WriteLine("Contact has been added");
        }
        public static void DisplayContact(List<Contact> list)
        {
            Console.WriteLine("Enter name to be searched ");
            string name1 = Console.ReadLine();
            foreach (Contact item in list)
            {
                if (item.ContactName == name1)
                {
                    Console.WriteLine("Contact number: {0},Contact Name:{1}, Cell Number :{2}", item.ContactNo, item.ContactName, item.CellNo);
                }
            }
        }
        public static void EditContact(List<Contact> list)
        {
            Console.WriteLine("Enter name to edit");
            string name = Console.ReadLine();
            Console.WriteLine("What do you want to change : 1.Contact number 2.Cell number 3.Both");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter contact number to be changed ");
                    int contact = Convert.ToInt32(Console.ReadLine());
                    foreach (Contact item in list)
                    {
                        if (item.ContactName == name)
                        {
                            item.ContactNo = contact;
                        }
                    }
                    Console.WriteLine("Contact has been changed");
                    break;
                case 2:
                    Console.WriteLine("Enter Cell number to be changed ");
                    string cell = Console.ReadLine();
                    foreach (Contact item in list)
                    {
                        if (item.ContactName == name)
                        {
                            item.CellNo = cell;
                        }
                    }
                    Console.WriteLine("Cell number has been changed");
                    break;
                case 3:
                    Console.WriteLine("Enter contact number to be changed ");
                    int contact1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Cell number to be changed ");
                    string cell1 = (Console.ReadLine());
                    foreach (Contact item in list)
                    {
                        if (item.ContactName == name)
                        {
                            item.ContactNo = contact1;
                            item.CellNo = cell1;
                        }
                    }
                    Console.WriteLine("Data has been edited");
                    break;
                default:
                    break;
            }

        }
        static void ShowAllContacts(List<Contact> list)
        {
            foreach (Contact item in list)
            {
                Console.WriteLine("Contact number : {0}, Contact Name : {1}, Cell number :{2}", item.ContactNo, item.ContactName, item.CellNo);
            }
        }
        static void Main(string[] args)
        {
            List<Contact> c = new List<Contact>();
            Console.WriteLine("Enter your choice ");
            for (int i = 0; ; i++)
            {


                Console.WriteLine("1.Add 2.Display 3.Edit 4.Display All");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        AddContact(c);
                        break;
                    case 2:
                        DisplayContact(c);
                        break;
                    case 3:
                        EditContact(c);
                        break;
                    case 4:
                        ShowAllContacts(c);
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
