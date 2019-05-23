using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addtime
{
    class TimeZone
    {
        int Hrs, mins;
        public TimeZone ShowTime(TimeZone t1, TimeZone t2)
        {
            TimeZone res = new TimeZone();
            res.Hrs = t1.Hrs + t2.Hrs;
            res.mins = t1.mins + t2.mins;
            if (res.mins >= 60)
            {
                res.Hrs++;
                res.mins = res.mins % 60;
            }
            return res;

        }
        static void Main(string[] args)
        {
            TimeZone t1 = new TimeZone();
            TimeZone t2 = new TimeZone();
            Console.WriteLine("Enter Hrs and mins for Time1");
            t1.Hrs = Convert.ToInt32(Console.ReadLine());
            t1.mins = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hrs and mins for Time2");
            t2.Hrs = Convert.ToInt32(Console.ReadLine());
            t2.mins = Convert.ToInt32(Console.ReadLine());
            TimeZone res = t1.ShowTime(t1, t2);
            Console.WriteLine(res.Hrs + " " + res.mins);
        }
    }
}
