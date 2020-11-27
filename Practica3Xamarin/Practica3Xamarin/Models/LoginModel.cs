using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Practica3Xamarin.Models
{
    public class LoginModel
    {
        [Required, MaxLength(60), EmailAddress]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
