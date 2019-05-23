using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class foreachloop
    {
        static void Main(string[] args)
        {
            string[] CityName = new string[10];
            int i = 0;
            while (i < 10)
            {
                CityName[i] = Console.ReadLine();
                i++;
            }
            foreach (string name in CityName)
            {
                Console.WriteLine(name);

            }
            Console.ReadKey();
        }
    }
}
