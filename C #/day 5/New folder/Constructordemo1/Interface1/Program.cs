using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    interface IOne
    {
        void Name();
        void Email();
    }
    class Priya : IOne
    {
        public void Name()
        {
            Console.WriteLine("Name is Priya");
        }
        public void Email()
        {
            Console.WriteLine("email is Priya@gamil.com");
        }
    }
    class Bhargav:IOne
    {
        public void Name()
        {
            Console.WriteLine("Name is bhargav");
        }
        public void Email()
        {
            Console.WriteLine("Email is Bhargav@gmail.com");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IOne[] arr = new IOne[]
            {
            new Bhargav(),new Priya()
            };
            foreach(IOne e in arr)
            {
                e.Name();
                e.Email();
            }
        }
    }
}
