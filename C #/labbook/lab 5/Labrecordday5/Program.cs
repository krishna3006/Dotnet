using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLibrary;
namespace LabRecordDay5
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount c1 = new ICICI();
            BankAccount c2 = new ICICI();

            c1.AccountType = BankAccountTypeEnum.Saving;
            c1.Deposit(50000);

            c2.AccountType = BankAccountTypeEnum.Current;
            c2.Deposit(20000);

            Console.WriteLine("Savings Balance : {0}", c1.GetBalance());
            Console.WriteLine("Current Balance : {0}", c2.GetBalance());

            c1.Transfer(c2, 5000);

            Console.WriteLine("Updated Savings Balance : {0}", c1.GetBalance());
            Console.WriteLine("Updated Current Balance : {0}", c2.GetBalance());
            c1.CalculateInterest();

            BankAccount c3 = new HSBC();
            BankAccount c4 = new HSBC();

            c3.AccountType = BankAccountTypeEnum.Current;
            c3.Deposit(100000);
            c4.AccountType = BankAccountTypeEnum.Saving;
            c4.Deposit(200000);

            Console.WriteLine("Current Balance : {0}", c3.GetBalance());
            Console.WriteLine("Savings Balance : {0}", c4.GetBalance());

            c4.Transfer(c3, 30000);

            Console.WriteLine("Updated Current Balance : {0}", c3.GetBalance());
            Console.WriteLine("Updated Savings Balance : {0}", c4.GetBalance());
            c4.CalculateInterest();

            Console.ReadKey();
        }
    }
}
