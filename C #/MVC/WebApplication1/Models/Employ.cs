using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employ
    {
        [Key]
        [Required(ErrorMessage = "Please enter Employ No")]
        public int Empno { get; set; }

        [MinLength(5, ErrorMessage = "Minimum 5 characters")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters")]
        [Required(ErrorMessage = "Please enter name")]
        public string name { get; set; }

        [MaxLength(10, ErrorMessage = "MAximum 10 characters")]
        [Required(ErrorMessage = "Please enter dept name")]
        public string Dept { get; set; }

        [MinLength(3, ErrorMessage = "Minimum 3 characters")]
        [MaxLength(10, ErrorMessage = "Maximum 10 characters")]
        [Required(ErrorMessage = "Designation is required")]
        public string Desig { get; set; }

        [RegularExpression(@"\d{5}$",ErrorMessage ="only 5 digits allowed")]
        [Required(ErrorMessage = "BAsic is required")]
        public int Basic { get; set; }
    }
}   