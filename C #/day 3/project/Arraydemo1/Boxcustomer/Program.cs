using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxcustomer
{
    class Customer
    {
        public int custId;
        public string custname;
        public double billamount;
    }
    class Program
    {
        public void Show(object ob)
        {
            Customer x = (Customer)ob;
            Console.WriteLine("{0} {1} {2}", x.custId, x.custname, x.billamount);  );
        }


        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.custId = 1;
            c.custname = "Bhargav";
            c.billamount = 2000;
            new Program().Show(c);
        }
    }

}
