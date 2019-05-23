using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong1
{
    class Program
       {
        static void Main(string[] args)
            {
                int n, temp, a,b,r;
                Console.WriteLine("Enter your starting no of the array");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the ending number of the array");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Armstrong Numbers between the range");
                for (n=a;n<b;n++)
                {
                    temp = n;
                    int sum = 0;
                    while (temp != 0)
                    {
                        r = temp % 10;
                        sum = sum + (r * r * r);
                        temp = temp / 10;
                    }
                    if (n == sum)
                    {
                    Console.WriteLine("The armstrong no is");
                    }
                }
               
            }
        }
    }

      

