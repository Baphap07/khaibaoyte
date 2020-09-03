using System;
using System.ComponentModel.DataAnnotations;

namespace health_declaration.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember Me")]
        public bool Rememberme { get; set; }
        
    }
}
