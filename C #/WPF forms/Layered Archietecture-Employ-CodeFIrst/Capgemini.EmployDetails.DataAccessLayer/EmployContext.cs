using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capgemini.EmployDetails.Entities;
using System.Data.Entity;

namespace Capgemini.EmployDetails.DataAccessLayer
{
    class EmployContext :DbContext
    {
        public EmployContext():base() { }
        public DbSet<Employ> Employs { get; set; }
    }
}
