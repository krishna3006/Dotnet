using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class structures
    {
        struct Number
        {
            private int number;

            public void square(int number)
            {
                this.number = number;

                Console.WriteLine("square of a number is{0}", this.number * number);
            }
            public void cube(int number)
            {
                this.number = number;
                Console.WriteLine("cube of a number is{0}", this.number * number * number);
            }
        }
        static void Main(string[] args)
        {
            Number s = new Number();
            Console.WriteLine("enter a number");
            int u = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what do you want to perform square ** or cube ***");
            string w = Console.ReadLine();
            if (w == "**")


                s.square(u);

            else if (w == "***")
                s.cube(u);
            else
                Console.WriteLine("you are entered wrong choice");
            Console.ReadKey();
        }



    }
}




