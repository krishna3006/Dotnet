using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEx
{
    class InvalidPaymodeException : Exception
    {
        public InvalidPaymodeException(string error) : base(error)
        {

        }
    } class InvalidPremiumException : Exception
    {
        public InvalidPremiumException(string error) : base(error)
        {

        }
    }
    class Customer
    {
        public int CustID { get; set; }
        public string Custname { get; set; }
        public double Premium { get; set; }
        public int Payrole { get; set; }
    }
    class Program
    {
        public void Check(int CustID, string Custname, double Premium, int Payrole
            {
            if (Paymode != 1 && Paymode != 2 && Paymode != 3)
            {
                throw new InvalidPaymodeException("invalid Paymode");
            }
            if (Premium < 100)
            {
                throw new InvalidPremiumException("Invalid Premium");
            }
            if (InvalidYearPremiumException == 1 && Premium < 1000)
            {
                throw new InvalidPaymodeException("Invald your premium");
            }
        }


        static void Main(string[] args)
        {
            Customer obj = new Customer();
            Console.WriteLine("Enter CustID,Name,Premium and Payrole");
            obj.CustID = Convert.ToInt32(Console.ReadLine());
            obj.Custname = (Console.ReadLine());
            obj.Premium = Convert.ToInt32(Console.ReadLine());
            obj.Payrole = Convert.ToInt32(Console.ReadLine());
            try
            {
                new Program().Check(obj.CustID, obj.Custname, obj.Premium, obj.Payrole);
            }
            catch (InvalidPaymodeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidPremiumException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidYearPremiumException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}


        
