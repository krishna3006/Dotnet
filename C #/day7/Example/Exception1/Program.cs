using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1
{
    class Program
    {
        public void Show()
        {
            int[] a = new int[] { 12,5 };
            try
            {
                a[10] = 62;
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine( "array size is small..." );
            }

            catch(Exception e)
            {
                Console.WriteLine(e);

            }
        }
        static void Main(string[] args)
        {
            new Program().Show();
        }
    }
}
