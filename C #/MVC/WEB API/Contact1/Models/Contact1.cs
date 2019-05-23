using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contact1.Models
{
    public class Contact1
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Email { get; set; }
    }
}