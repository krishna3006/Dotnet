using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("enter a number to check:");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while(n>0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("The given number is Armstrong number");
            }
            else
            {
                Console.WriteLine("Not an armstrong number");
            }
        }
    }
}
