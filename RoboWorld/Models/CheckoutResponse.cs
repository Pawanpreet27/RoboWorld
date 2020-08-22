using System.ComponentModel.DataAnnotations;

namespace RoboWorld.Models
{
    public class CheckoutResponse
    {
        [Required (ErrorMessage ="Name is a required field")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is a required field")]
        public string Address { get; set; }
        [Required(ErrorMessage = "City is a required field")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter your postal code")]
        public string postalCode { get; set; }

    }
}
