using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CodeFirstApproach.Models
{
    public class EmployContext:DbContext
    {
        public DbSet<Employ> Employees { get; set; }
    }
}