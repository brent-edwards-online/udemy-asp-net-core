using System.ComponentModel.DataAnnotations;

namespace CourseProjectApp.ViewModels.Main
{
    public class RegisterViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Passwords must match")]
        public string ComparePassword { get; set; }

        

    }
}
