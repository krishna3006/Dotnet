using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nulltype
{
    class Program
    {
        public void Show()
        {
            int? examscore = null;
            double? salary = null;

            salary = 85256;
            /*check about null value*/
            if (examscore.HasValue)
            {
                Console.WriteLine("Score is" + examscore);
            }
            else
            {
                Console.WriteLine("STill Exam not hapened...");
            }
            if(salary.HasValue)
            {
                Console.WriteLine("Salary is" + salary);
            }
            else
            {
                Console.WriteLine("Not applicable");
            }
            
        }
        static void Main(string[] args)
        {
            new Program().Show();
        }
    }
}
