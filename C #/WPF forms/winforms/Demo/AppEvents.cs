using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class AppEvents
    {
        public static event DisplayEmployeeHandler ShowEmployEvent = null;
        public static void OnShowEmployeeEvent(Employee employee)
        {
            if
            {
                ShowEmployeeEvent != null
                ShowEmployeeEvent(employee);;
            }

        }        
    }
}
y