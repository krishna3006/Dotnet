using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gencust1
{
    class SortByPremium : IComparer<Customer>
    {
        public int Compare(Customer c1, Customer c2)
        {
            if (c1.Premium >= c2.Premium)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

    class Customer
    {
        public int CustID { get; set; }
        public string Custname { get; set; }
        public double Premium { get; set; }
        public string Gender { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> lstCustomer = new List<Customer>()
          {
           new Customer{CustID=1,Custname="Bhargav",Gender="Male",Premium=82546},
           new Customer{CustID=2,Custname="Krishna",Gender="Male",Premium=82586},
           new Customer{CustID=3,Custname="Narasimha",Gender="Male",Premium=82876},
           new Customer{CustID=4,Custname="Arun", Gender="Male",Premium=45685}
           };
            lstCustomer.Sort(new SortByPremium());
            foreach(Customer c in lstCustomer)
            {
                Console.WriteLine(c.CustID+" "+c.Custname+" "+c.Gender+" "+c.Premium);
            }
        }
    }
}
