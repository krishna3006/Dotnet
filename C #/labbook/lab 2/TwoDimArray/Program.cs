using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class TwoDimArray
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5, 6];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());

                }

            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();


            }
            Console.ReadKey();
        }
    }
}

