using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Demo
    {
        public delegate void Training(string participant);
        public static event Training ReportOnTime;
        public static event Training EscalateToHR;
        public static void Venue(string Venue)
        {
            Console.WriteLine("Venue is");
        }

        public static void OnTime(string participant)
        {
            Console.WriteLine("You came ontime please go to class");
        }
        public static void HRreport(string participant)
            {
            Console.WriteLine(participant+"meet HR");
        }
        static void Main(string[] args)
        {
            int hr;
            string student;
            Training obj = new Training(Venue);
            Console.WriteLine("Enter participant name and login time hr..");
            string name = Console.ReadLine();
            hr = Convert.ToInt32(Console.ReadLine());
            if (hr <= 9)
            {
                ReportOnTime += new Training(OnTime);
                ReportOnTime(student);
            }
            else
            {
                EscalateToHR += new Training(HrReport);
                EscalateToHR(student);
            }


        }
    }
}
