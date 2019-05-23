using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRecordDay10
{
    delegate int Operations(int a, int b);
    class Program4
    {

        public static Operations add = delegate (int a, int b)
        {
            return a + b;
        };
        public static Operations subtract = delegate (int a, int b)
        {
            return a - b;
        };
        public static Operations multiply = delegate (int a, int b)
        {
            return a * b;
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; ; i++)
            {
                Console.WriteLine("Enter Chice");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {

                    case 1:
                        Console.WriteLine(add(a, b));

                        break;
                    case 2:

                        Console.WriteLine(subtract(a, b));
                        break;
                    case 3:

                        Console.WriteLine(multiply(a, b));
                        break;
                }
                // Console.ReadKey();
            }
        }
    }
}

