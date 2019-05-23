using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDetails.Exceptions
{
    public class PatientException:ApplicationException
    {
        public PatientException():base()
        { }
        public PatientException(string error):base(error)
        { }
    }
}
