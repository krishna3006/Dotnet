using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcDemo2.Models
{
    public class Employ
    {
        [Key]
        [Required(ErrorMessage ="Employ Number is Required")]
        public int EmpNo { get; set;}

        [Required(ErrorMessage ="Name is Required")]
        [MinLength(5,ErrorMessage ="Minimum 5 chars")]
        [MaxLength(12,ErrorMessage ="Maximum 12 chars")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Dept is Required")]
        [MaxLength(10,ErrorMessage ="Maximum 12 chars")]
        public string Dept { get; set; }

        [Required(ErrorMessage = "Desig is Required")]
        [MinLength(3,ErrorMessage ="Minimum 3 Chars")]
        [MaxLength(10,ErrorMessage ="Maximum 10 chars")]
        public string Desig { get; set; }

        [Required(ErrorMessage = "Basic is Required ")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Only Five Digits allowed")]
        public int Basic { get; set; }
    }
}