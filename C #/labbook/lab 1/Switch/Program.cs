using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchLibrary
{
    public class switchcase
    {
        private int choice;
        public switchcase()

        {
            Console.WriteLine("enter your choise : ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("you are entered : 1");
                    break;
                case 2:
                    Console.WriteLine("you are entered : 2");
                    break;
                case 3:
                    Console.WriteLine("you are entered : 3");
                    break;
                case 4:
                    Console.WriteLine("you are entered : 4");
                    break;
                case 5:
                    Console.WriteLine("you are entered : 5");
                    break;
                default:
                    Console.WriteLine("you are entered wrong choise");
                    break;
            }
        }
        static void Main(string[]args)
        {
            switchcase s = new switchcase();
            Console.ReadKey();

        }
    }
}


