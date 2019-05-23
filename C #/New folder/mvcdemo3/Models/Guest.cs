using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvcdemo3.Models
{
    public class Guest
    {
        [Key]
        [Required(ErrorMessage ="ID is Required")]
        [RegularExpression(@"^\d{3}$", ErrorMessage ="Only three Digit Allowed")]
        [Display(Name ="Guest No")]
        public int GuestNo { get; set; }
        [Required(ErrorMessage ="Name is Required")]
        public string GuestName { get; set; }
        [Required(ErrorMessage ="Phone number is required")]
        [StringLength(10,ErrorMessage ="Only 10 Character is allowed")]
        public string PhoneNumber { get; set; }
    }
}