using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDetails.Entity
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientType { get; set; }
    }
}
