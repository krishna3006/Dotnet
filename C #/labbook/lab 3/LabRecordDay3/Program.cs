using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace LabRecordDay3
{
    class Car
    {
        public string make;
        public string model;
        public int year;
        public int price;
        // int top = -1;

        public void add(string make, string model, int year, int price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;


        }
        public void display()
        {
            Console.WriteLine("Make: {0}\tModel: {1}\tYear: {2}\tPrice: {3}", make, model, year, price);
        }

    }
    class Lab3Ex3
    {
        static void Main(string[] args)
        {
            int top = -1;
            Console.WriteLine("Enter the size of the Catalogue:");
            int size = Convert.ToInt32(Console.ReadLine());

            Car[] c = new Car[size];
            for (int i = 0; ; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Choose any one among the below ");
                Console.WriteLine("1.Add , 2.Delete , 3.Search , 4.Modify , 5.Display , 6.Quit");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        if (top + 1 < size)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter the make of the car :");
                            string make = Console.ReadLine();
                            Console.WriteLine("Enter the model : ");
                            string model = Console.ReadLine();
                            Console.WriteLine("Enter year : ");
                            int year = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter price : ");
                            int price = Convert.ToInt32(Console.ReadLine());
                            c[++top] = new Car();
                            c[top].add(make, model, year, price);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Catalogue is full");
                        }

                        break;
                    case 2:
                        if (top > -1)
                        {
                            --top;
                            Console.WriteLine();
                            Console.WriteLine("The List {0} has been deleted", top + 2);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Catalogue is empty");
                        }
                        break;
                    case 3:
                        if (top > -1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter the make to be searched : ");
                            string make1 = Console.ReadLine();
                            Console.WriteLine("Enter the model to be searched");
                            string model1 = Console.ReadLine();
                            for (int k = 0; k <= top; k++)
                            {
                                if (c[k].make == make1 && c[k].model == model1)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("List Found at index {0}", k + 1);
                                    goto found;
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("List Not Found");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("The catalogue is empty");
                        }
                    found: break;
                    case 4:
                        if (top > -1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter the make to be modified");
                            string make2 = Console.ReadLine();
                            for (int l = 0; l <= top; l++)
                            {
                                if (c[l].make == make2)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Enter the details to be modified : ");
                                    Console.WriteLine("Enter make : ");
                                    string make3 = Console.ReadLine();
                                    Console.WriteLine("Enter model:");
                                    string model2 = Console.ReadLine();
                                    Console.WriteLine("Enter year");
                                    int year1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter price");
                                    int price1 = Convert.ToInt32(Console.ReadLine());

                                    c[l].make = make3;
                                    c[l].model = model2;
                                    c[l].year = year1;
                                    c[l].price = price1;
                                    Console.WriteLine();
                                    Console.WriteLine("List has been modified");
                                    goto found1;
                                }


                            }
                            Console.WriteLine();
                            Console.WriteLine("There's no such list");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("The catalogue is empty");
                        }

                    found1: break;

                    case 5:
                        if (top > -1)
                        {
                            for (int j = 0; j <= top; j++)
                            {
                                Console.WriteLine();
                                Console.Write("{0}. ", j + 1);
                                c[j].display();
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("The catalogue is empty");
                        }
                        break;
                    case 6:
                        Console.WriteLine();
                        Console.WriteLine("You have successfully quit the process.....Terminating in 3 seconds");
                        Thread.Sleep(4000);
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Incorrect Input....Terminating the process in 2 seconds");
                        Thread.Sleep(3000);
                        return;
                }

            }
        }

    }
}
