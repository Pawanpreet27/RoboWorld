using System.ComponentModel.DataAnnotations;

namespace RoboWorld.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Please enter your name!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your password!")]
        [RegularExpression("^.{4,8}$", ErrorMessage = "Please enter a valid password, must be 4-8 length long")]
        [UIHint("password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter your email address!")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter your phone number!")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Please enter only digits for Phone Number")]
        public int? PhoneNumber { get; set; }
        public bool? IsAdmin { get; set; }        
    }
}
