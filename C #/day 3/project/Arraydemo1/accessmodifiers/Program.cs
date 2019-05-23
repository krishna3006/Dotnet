using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessmodifiers
{
    class Demo
    {
        public void Bhargav()
        {
            Console.WriteLine("Bhargav");
        }
        private void Pallavi()
        {
            Console.WriteLine("Pallavi");
        }
        internal void Siva()
        {
            Console.WriteLine("Siva");
        }
    }
    class Program
    {       
        static void Main(string[] args)
        {
            new Demo().Bhargav();
            new Demo().Pallavi();
            new Demo().Siva();
        }
    }
}
