using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsIcici
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

        public delegate void Credit(int amount);
        public event Credit amountPaid;

        public static void Payment(int amount)
        {
            Console.WriteLine("Payment Paid for Amount " + amount);
        }

        public void MakePayment(int instAmount)
        {
            BalanceAmount = BalanceAmount + instAmount;
            amountPaid += new Credit(Payment);
            amountPaid(instAmount);
        }

    }
}

