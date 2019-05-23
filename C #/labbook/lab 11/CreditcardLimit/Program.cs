using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreditCardClient
{
    public class CreditCard
    {
        public string CreditCardNo { get; set; }
        public string CardHolderName { get; set; }
        public int BalanceAmount { get; set; }
        public int CreditLimit { get; set; }

        public int GetBalance()
        {
            return BalanceAmount;
        }

        public int GetCreditLimit()
        {
            return CreditLimit;
        }

        public delegate void Credit(int amount, CreditCard c);
        public static event Credit amountPaid;

        public static void Payment(int amount, CreditCard c)
        {
            Console.WriteLine("Payment Paid for Amount " + amount);
        }

        public static void MakePayment(int instAmount, CreditCard c)
        {
            c.BalanceAmount = c.BalanceAmount + instAmount;
            amountPaid += new Credit(Payment);
            amountPaid.Invoke(instAmount, c);
        }


        static void Main(string[] args)
        {
            CreditCard c = new CreditCard();
            c.CreditCardNo = "123455666";
            c.CreditLimit = 100000;
            c.CardHolderName = "Bhargav";
            c.BalanceAmount = 14455;
            Console.WriteLine("Enter CreditCard Amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Credit cs = new Credit(MakePayment);
            cs(amount, c);
            Console.WriteLine(c.BalanceAmount);
        }
    }
}

