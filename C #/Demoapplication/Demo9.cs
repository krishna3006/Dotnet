using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoapplication
{
    class Demo9
    {
        public void Check(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }
        }
                    static void Main(String[] args)
            {
                int n;
                Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            Demo9 obj = new Demo9();
            obj.Check(n);

            }
        }
    }

