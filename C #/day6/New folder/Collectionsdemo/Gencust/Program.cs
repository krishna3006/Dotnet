using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gencust
{
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
            foreach (Customer cu in lstCustomer)
            {
                Console.WriteLine(lstCustomer);
            }
        }
    }
}
