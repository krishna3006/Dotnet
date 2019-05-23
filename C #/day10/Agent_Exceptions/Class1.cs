using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_Exceptions
{
    public class AgentException : ApplicationException
    {
        public AgentException() : base()
        {

        }
        public AgentException(string error) : base(error)
        {

        }
    }
}
