using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MCVDemo2.Views.Home
{
    public class Guest
    {
        [Required(ErrorMessage ="ID is required")]
        [RegularExpression(@"^\d{3}$",ErrorMessage ="Only three digits allowed")]
        [Display(Name ="Guest No")]
        public int Guestno { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public string GuestName { get; set; }
        [Required(ErrorMessage ="Phonenumber is required")]
        [StringLength(10,ErrorMessage ="Only 10 characters are allowed")]
        public string PhoneNumber { get; set; }
    }
}