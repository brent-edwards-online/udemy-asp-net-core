using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.ViewModels.Main
{
    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6,ErrorMessage = "The password must be between 6 and 50 characters")]
        [MaxLength(50, ErrorMessage = "The password must be between 6 and 50 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]        
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords must match")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}
