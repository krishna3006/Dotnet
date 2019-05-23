using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public enum BankAccountTypeEnum
    {
        Current = 1,
        Saving = 2
    }
    public interface IBankAccount
    {
        double GetBalance();
        void Deposit(double amount);
        // bool Withdraw(double amount);
        bool Transfer(IBankAccount toAccount, double amount);
        BankAccountTypeEnum AccountType { get; set; }
        void CalculateInterest();
    }
    public abstract class BankAccount : IBankAccount
    {
        protected double balance;
        public BankAccountTypeEnum AccountType { get; set; }

        public virtual void Deposit(double amount)
        {
            balance += amount;
        }

        public double GetBalance()
        {
            return balance;
        }

        public virtual bool Transfer(IBankAccount toAccount, double amount)
        {
            bool status = false;
            try
            {
                toAccount.Deposit(amount);
                this.balance -= amount;
                status = true;
            }
            catch
            {
                status = false;
            }
            return status;
        }

        public virtual bool Withdraw(double amount)
        {
            bool status = false;
            try
            {
                balance -= amount;
                status = true;
            }
            catch
            {
                status = false;
            }
            return status;

        }
        public virtual void CalculateInterest()
        {

        }
    }
    public class ICICI : BankAccount
    {
        public override void Deposit(double amount)
        {
            base.Deposit(amount);
        }
        public override bool Transfer(IBankAccount toAccount, double amount)
        {
            return base.Transfer(toAccount, amount);
        }
        public override void CalculateInterest()
        {

            balance = balance + (balance * 0.07);
            Console.WriteLine("After interest, Savings Balance: {0}", balance);
        }
    }
    public class HSBC : BankAccount
    {
        public override void Deposit(double amount)
        {
            base.Deposit(amount);
        }
        public override bool Transfer(IBankAccount toAccount, double amount)
        {
            return base.Transfer(toAccount, amount);
        }
        public override void CalculateInterest()
        {

            balance = balance + (balance * 0.05);
            Console.WriteLine("After interest, Savings Balance: {0}", balance);
        }
    }

}
