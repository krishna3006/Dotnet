using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class AppEvent
    {
        public static event DisplayEmployeeHandler ShowEmployeeEvent = null;
        public static event DisplayStudentHandler ShowStudentEvent = null;

        public static void OnShowStudentEvent(Student student)
        {
            if (ShowStudentEvent)
        }
    }
}
