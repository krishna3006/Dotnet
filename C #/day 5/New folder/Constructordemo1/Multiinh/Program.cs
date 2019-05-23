using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiinh
{
    interface IOne
    {
        void name();
    }
    interface ITwo
    {
        void Email();
    }
    class Data:IOne,ITwo
    {
        public void Name()
        {
            Console.WriteLine("Abridge tech");
        }
        public void Email()
        {
            Console.WriteLine("Abridge@gamil.com");
        }

        void IOne.name()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Data obj = new Data();
            obj.Name();
            obj.Email();

        }
    }
}
