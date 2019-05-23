using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHN_Exception
{
    public class GuestException:ApplicationException
    {
        public GuestException() : base()
        {

        }
        public GuestException(string error) : base(error)
        {

        }
    }
}
