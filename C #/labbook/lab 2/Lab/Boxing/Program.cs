using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class boxing
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Product id: ");
            int ProductID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Product Quantity: ");
            int Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name Of Prodect: ");
            string NameOfProduct = Console.ReadLine();
            Console.WriteLine("Enter the Product Price: ");
            float Price = Convert.ToSingle(Console.ReadLine());
            double amount = Price * Quantity;
            object ob = ProductID;
            object ob1 = Quantity;
            object ob2 = NameOfProduct;
            object ob3 = Price;
            object ob4 = amount;
            ProductID = (int)ob;
            Quantity = (int)ob1;
            NameOfProduct = (string)ob2;
            Price = (float)ob3;
            amount = (double)ob4;
            Console.WriteLine("Product details: ");
            Console.WriteLine("Product Id: {0}", ProductID);
            Console.WriteLine("Product name: {0}", NameOfProduct);
            Console.WriteLine("Price of the item: {0}", Price);
            Console.WriteLine("Quantity of the item required: {0}", Quantity);
            Console.WriteLine("Amount Payable is: {0}", amount);
            Console.ReadKey();
        }
    }

}



