
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRecord3
{
    class Supplier
    {
        private int supplierID;
        private string supplierName;
        private string city;
        private string phoneNo;
        private string email;

        public void AcceptDetails(int id, string name, string city, string num, string email)
        {
            supplierID = id;
            supplierName = name;
            this.city = city;
            phoneNo = num;
            this.email = email;

        }
        public void DisplayDetails()

        {
            // Console.WriteLine("Supplier Details: ");
            Console.WriteLine("Id: {0}", supplierID);
            Console.WriteLine("Name: {0}", supplierName);
            Console.WriteLine("City: {0}", city);
            Console.WriteLine("Mobile Number: {0}", phoneNo);
            Console.WriteLine("Email Id: {0}", email);
        }

    }
    class Lab3Ex4
    {
        static void Main(string[] args)
        {
            Supplier[] supp = new Supplier[2];
            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("Enter the Supplier Details:");
                Console.WriteLine("Enter details of supplier {0}", i + 1);
                Console.WriteLine("Enter Supplier Id:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Supplier name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Supplier City:");
                string city = Console.ReadLine();
                Console.WriteLine("Enter supplier Mobile No: ");
                string num = Console.ReadLine();
                Console.WriteLine("Enter supplier email:");
                string email = Console.ReadLine();

                supp[i] = new Supplier();
                supp[i].AcceptDetails(id, name, city, num, email);
                Console.WriteLine("The details of the supplier {0} is :", i + 1);
                supp[i].DisplayDetails();

            }
            /*for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("The details of the supplier {0} is :", i + 1);
                supp[i].DisplayDetails();
            }*/
            Console.ReadKey();
        }
    }
}
