using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproach.Models
{
    public class Employ
    {
        [Key]
        public int Empno { get; set; }
        public string name { get; set; }
        public string Dept { get; set; }
        public string Desig { get; set; }
        public int Basic { get; set; }

    }
}