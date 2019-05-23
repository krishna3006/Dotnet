using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringexample
{
    class Nosymbol : Exception
    {
        public Nosymbol(string error) : base(error)
        {
        }
    }
    class Maximum : Exception
    {
        public Maximum(string error) : base(error)
        {

        }
    }

    class Program
    {
        public void Check(string s)

        {
            int n;
            n = s.IndexOf("@");
            if (n == -1)
            {
                throw new Nosymbol("no @ symbol present");

            }
            if (n > 12)
            {
                throw new Maximum("exceeded 12 numbers");
            }
            else
            {
                Console.WriteLine("the email id is acceptable");
            }



        }

        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Enter the email id");
            a = Console.ReadLine();
            try
            {
                new Program().Check(a);
            }
            catch (Nosymbol e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Maximum e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
        

   
