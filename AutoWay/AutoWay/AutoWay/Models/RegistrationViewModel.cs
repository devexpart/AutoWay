using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoWay.Models
{
    public class RegistrationViewModel
    {

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string Username { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string Gender { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 3)]
        public string Address { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string City { get; set; }

        [Required]
        //[RegularExpression(@"/\+\d{1,4}-(?!0)\d{1,10}\b/g$", ErrorMessage = "Mobile no not valid")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [NotMapped] // Does not effect with database
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
