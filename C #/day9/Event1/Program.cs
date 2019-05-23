using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event1
{
    class Program
    {
        public int StockId { get; set; }
        public string Stockname { get; set; }
        public double Quantity { get; set; }
        public double price { get; set; }
        public delegate void Store();
        public static event Store InvalidStock;
        public static event Store OrderSuccess;
        public static void Invalid()
        {
            Console.WriteLine("Invalid order");
        }
        public static void Success()
        {
            Console.WriteLine("Order Successful");
        }
        public static void Check(int Id, double Qorder, Program s)
        {
            if (s.Quantity <= Qorder)
            {
                OrderSuccess += new Store(Success);
                OrderSuccess();
                Console.WriteLine("Total Amount is" + (Qorder * s.price));
            }
            else
            {
                InvalidStock += new Store(Invalid);
                InvalidStock();
            }
        }
        static void Main(string[] args)
        {
            Program s = new Program();
            s.StockId = 1;
            s.Stockname = "RiceBag";
            s.Quantity = 1500;
            s.price = 6000;
            Console.WriteLine("enter stockid and Quantity");
            
        }
    }
}
