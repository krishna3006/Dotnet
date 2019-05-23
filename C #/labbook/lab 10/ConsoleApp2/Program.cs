using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrecordday10
{
    delegate int MyDelegate(int a, int b);
    class ArithmeticOperation
    {
        public void PerformArithmeticOperation(int a, int b, MyDelegate op)
        {
            Console.WriteLine(op(a, b));
        }
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {
            return a / b;
        }
        public int Biggest(int a, int b)
        {
            return (a > b) ? a : b;
        }

    }
    class program2
    {

        static void Main()
        {
            ArithmeticOperation o = new ArithmeticOperation();

            Console.Write("Enter no1 : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter no2 : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("1.Add\n2.sub\n3.mult\n4.Div\nEnter choice :");
            int ch = Convert.ToInt32(Console.ReadLine());
            MyDelegate d;
            switch (ch)
            {
                case 1:
                    d = new MyDelegate(o.Addition);
                    break;
                case 2:
                    d = new MyDelegate(o.Subtraction);
                    break;
                case 3:
                    d = new MyDelegate(o.Multiplication);
                    break;
                case 4:
                    d = new MyDelegate(o.Division);
                    break;
                case 5:
                    d = new MyDelegate(o.Biggest);
                    break;
                default:
                    d = new MyDelegate(o.Addition);
                    break;
            }
            o.PerformArithmeticOperation(a, b, d);

            Console.ReadKey();
        }
    }
}
