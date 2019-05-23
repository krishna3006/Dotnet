using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        public void Calc(int a, int b)
        {
            int c = a / b;
            Console.WriteLine("Div" +c);
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two numbers");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                new Program().Calc(a, b);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Division by zero impossible");
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Number is too big");
            }
            catch(FormatException e)
            {
                Console.WriteLine("string cannot be converted as integer");
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);

            }
            finally
            {
                Console.WriteLine("Program by Bhargav");
            }
        }
    }
}
