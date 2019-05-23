using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.PatientDetails.Exceptions
{
    public class PatientException:ApplicationException
    {
        public PatientException() : base()
        { }
        public PatientException(string error) : base(error)
        { }
        public PatientException(string err, Exception inner) : base(err, inner) { }

    }
}
