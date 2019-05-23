using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{

    class Customer
    {
        public int Customerid;
        public string Customername;
        public string City;
        public int Phone;
        public double Creditlimit;
    }
    class CustomerException : Exception
    {
        public CustomerException(string error) : base(error)
        { }
    }
    class Program
    {
        public void Show(int x, string m, string n, int y, double o)
        {

            if (o > 50000)
            {
                throw new CustomerException("invalid credit limit customer exception");
            }
            else { Console.WriteLine("transaction is succesfull"); }

            Customer p = new Customer();
            p.Customerid = x;
            p.Customername = m;
            p.City = n;
            p.Phone = y;
            p.Creditlimit = o;



        }
        static void Main(string[] args)
        {
            int x, y;
            string m, n;
            double o;
            Console.WriteLine("enter the details");
            Console.WriteLine("customerid");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("customername");
            m = Console.ReadLine();
            Console.WriteLine("city");
            n = Console.ReadLine();
            Console.WriteLine("phone");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("credit limit");
            o = Convert.ToDouble(Console.ReadLine());

            try
            {
                new Program().Show(x, m, n, y, o);
            }

            catch (CustomerException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {

                throw;
            }





        }

    }
}


