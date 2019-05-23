using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializeDemo
    [Serializable]
        public class Customer
{
    private int CustId;
    private string custname;
    private double premium;

    public Customer(int CustId,string custname,double Premium)
    {
        this.CustId = CustId;
        this.custname = custname;
        this.premium = premium;
    }
}

    public void Show()
    {
        Console.WriteLine($"CustId{CustId} Name{custname}Premium {premium});
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"c:\files\Customer.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter form = new BinaryFormatter();
            Customer c = new Customer(1,"Bhargav", 55552);
            form.Serialize(fs, c);
            fs.Close();
        }
    }
}
