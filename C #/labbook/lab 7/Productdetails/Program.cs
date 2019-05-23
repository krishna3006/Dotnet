using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace LabRecordDay7
{
    class ProductDetails
    {
        public int ProductNo { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Rate { get; set; }

    }
    class Program2
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            // ProductDetails p  = new ProductDetails();

            ArrayList list = new ArrayList();
            for (int i = 0; ; i++)
            {
                Console.WriteLine("Enter a choice 1.Add 2.Delete 3.Search 4.Save 5.Display");
                int ch = Convert.ToInt32(Console.ReadLine());
                ProductDetails p;
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Product Number ");
                        int no = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product name ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Stock");
                        int stock = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Rate");
                        int rate = Convert.ToInt32(Console.ReadLine());
                        list.Add(p = new ProductDetails { ProductNo = no, Name = name, Stock = stock, Rate = rate });
                        Console.WriteLine("Details Entered");
                        break;
                    case 2:
                        Console.WriteLine("Enter name to delete");
                        string name1 = Console.ReadLine();
                        // int n = list.IndexOf(name1);
                        //Console.WriteLine(n);
                        int count = -1;
                        foreach (ProductDetails item in list)
                        {
                            count++;
                            if (item.Name == name1)
                            {
                                break;
                            }
                            //Console.WriteLine("dsfsdf");
                        }
                        list.RemoveAt(count);
                        Console.WriteLine("The list has been deleted");
                        break;
                    case 3:
                        Console.WriteLine("Enter Product number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        foreach (ProductDetails item in list)
                        {
                            if (item.ProductNo == num)
                            {
                                Console.WriteLine("{0} ,{1} ,{2} ,{3}", item.ProductNo, item.Name, item.Rate, item.Stock);
                                goto found;
                            }

                        }
                        Console.WriteLine("The product not found");
                    found: break;
                    case 4:

                        break;
                    case 5:
                        foreach (ProductDetails item in list)
                        {
                            Console.WriteLine("{0},{1},{2},{3}", item.ProductNo, item.Name, item.Rate, item.Stock);
                        }
                        break;
                }
            }
        }
    }
}
