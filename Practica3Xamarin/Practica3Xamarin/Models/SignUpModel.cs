using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Practica3Xamarin.Models
{
    public class SignUpModel
    {
        [Required, MaxLength(20)]
        public string Name { get; set; }
        [Required, MaxLength(60), EmailAddress]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
