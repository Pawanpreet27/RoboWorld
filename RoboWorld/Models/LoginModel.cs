using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RoboWorld.Models
{
    public class LoginModel
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter your Email-ID")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string EmailID { get; set; }

        [Required(ErrorMessage = "Please enter your Password")]
        [UIHint("password")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; } = "/";
    }
}
