using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrecordday10
{
    class arithop
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            return a / b;
        }
        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }
    class Program
    {
        delegate int MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            Console.Write("Enter no1 :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter no2 :");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("1.Add\n2.Sub\n3.Mul\n4.Div\n5.Max:");
            int ch = Convert.ToInt32(Console.ReadLine());

            MyDelegate d;
            switch (ch)
            {
                case 1:


                    d = new MyDelegate(arithop.Addition);
                    break;

                case 2:


                    d = new MyDelegate(arithop.Subtraction);
                    break;

                case 3:


                    d = new MyDelegate(arithop.Multiplication);
                    break;

                case 4:


                    d = new MyDelegate(arithop.Division);
                    break;

                case 5:

                    d = new MyDelegate(arithop.Max);

                    break;


                default:

                    d = new MyDelegate(arithop.Addition);
                    break;
            }
            Console.WriteLine("{0} is {1}", ch, d(a, b));
            Console.ReadKey();




        }
    }
}








