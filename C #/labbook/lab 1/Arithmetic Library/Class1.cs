using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticLibrary
{
    public class Calculator
    {
        private int num1, choice;
        private double num2;
        public void Reading()
        {
            Console.WriteLine("enter num1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2 : ");
            num2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("enter choise from 1-5: ");
            choice = Convert.ToInt32(Console.ReadLine());



            switch (choice)
            {
                case 1:
                    Console.WriteLine("sum out put is {0} + {1} = {2}", num1, num2, num1 + num2);
                    break;
                case 2:
                    Console.WriteLine("sub out put is {0} - {1} = {2}", num1, num2, num1 - num2);
                    break;
                case 3:
                    Console.WriteLine("mul out put is {0} * {1} = {2}", num1, num2, num1 * num2);
                    break;
                case 4:
                    Console.WriteLine("Reminder out put is {0} / {1} = {2}", num1, num2, num1 / num2);
                    break;
                case 5:
                    Console.WriteLine("Module out put is {0} % {1} = {2}", num1, num2, num1 % num2);
                    break;
                default:
                    Console.WriteLine("you are entered wrong choice");
                    break;

            }
        }
    }
}

