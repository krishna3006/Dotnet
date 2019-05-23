using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraydemo1
{
    class Program
    {
        public void ShowArray()
        {
            int[] arr = new int[] { 12, 5, 67, 23, 33, 24 };
            ///for(int i=0;i<arr.Length;i++)
            ///{
            ///
            //Console.WriteLine(arr[i]);
           /// i=4;
           /// }
           foreach(int i in arr)
                {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.ShowArray();
        }
    }
}
