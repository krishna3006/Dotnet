using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custexp
{
    class NegativeException:Exception
    {
        public NegativeException(string error):base(error)
        {
        }
    }
    class NumberzeroException : Exception
    {
        public NumberzeroException(string error):base(error)
        {

        }
    }
    class Program
    {
        public void Check(int a, int b)
        {
            bool flag = true;
            if (a < 0 || b < 0)
            {
                flag = false;
                throw new NegativeException("negative nos not allowed");
            }
            if(a==0||b==0)
            {
                flag = false;
                throw new NumberzeroException("zero is invalid..");
            }
            if(flag==true)
            {
                int c = a + b;
                Console.WriteLine("sum is" +c);
            }
        }

        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            try
            {
                new Program().Check(a, b);
            }
            catch (NegativeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NumberzeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {

                Console.WriteLine(e);
            }
        }
    }
}
