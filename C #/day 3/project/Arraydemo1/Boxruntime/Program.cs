using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxruntime
{
    class Program
    {
        private static Program obj;

        public void Show(object ob)
        {
            Console.WriteLine(ob.GetType().Name);
            {
                string type = ob.GetType().Name;
                if (type.Equals("Int32"))
                {
                    Console.WriteLine("Integer Casting");
                    int x = (Int32)ob;
                    Console.WriteLine("X value" + x);
                }
                if (type.Equals("Double"))
                {
                    Console.WriteLine("Double Casting");
                    double x = (Double)ob;
                    Console.WriteLine("X value" + x);
                }
            }
        }
            static void Main(string[] args)
            {
                int x = 12;
                double y = 12.5;
                string name = "Bhargav";
                Program.obj = new Program();
                obj.Show(x);
                obj.Show(y);
                obj.Show(name);
            }
        }

        }
    

    


