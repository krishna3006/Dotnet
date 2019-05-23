using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Productmock
    {
        public int ProductId;
        public string ProductName;
        public double ProductPrice;


    }
    class IdException : Exception
    {

        public IdException(string error) : base(error)
        { }
    }
    class Nameexception : Exception
    {
        public Nameexception(string error) : base(error)
        { }
    }
    class Priceexception : Exception
    {
        public Priceexception(string error) : base(error)
        { }
    }
    class Program
    {
        public void Show(int x, string y, double z)
        {
            int l;
            l = y.Length;
            if (l == 0)
            {
                throw new Nameexception("product name cannot be left blank");
            }
            if (x <= 0)
            {
                throw new IdException("product id must be greater than zero");
            }
            if (z <= 0)
            {
                throw new Priceexception("price of product must be grater than zero");

            }

            Productmock p = new Productmock();
            p.ProductId = x;
            p.ProductName = y;
            p.ProductPrice = z;

        }
        static void Main(string[] args)
        {
            int x; string y; double z;
            Console.WriteLine("enter the details\n\nproduct id\nproductname\nproduct price");
            x = Convert.ToInt32(Console.ReadLine());
            y = (Console.ReadLine());
            z = Convert.ToDouble(Console.ReadLine());
            try
            {
                new Program().Show(x, y, z);
            }
            catch (IdException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Nameexception e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Priceexception e)
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
