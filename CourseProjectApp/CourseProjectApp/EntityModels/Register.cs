using System;
using System.ComponentModel.DataAnnotations;

namespace CourseProjectApp.EntityModels
{
    public class Register
    {
        [Key]
        public Guid ID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}   
