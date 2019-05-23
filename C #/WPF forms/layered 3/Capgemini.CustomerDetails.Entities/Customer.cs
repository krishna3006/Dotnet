using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Capgemini.CustomerDetails.Entities
{
    public class Customer
    {
        public Customer()
        {
            CustID = 0;
            CustName = string.Empty;
            City = string.Empty;
            BillAmount = 0;
            Dob = DateTime.Now;
        }
        [Key]
        public int CustID { get; set; }
        public string CustName { get; set; }
        public string City { get; set; }
        public DateTime Dob { get; set; }
        public int BillAmount { get; set; }
    }
}




