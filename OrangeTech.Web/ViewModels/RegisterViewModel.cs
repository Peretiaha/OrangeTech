using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeTech.Web.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(20), MinLength(6)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [MaxLength(20), MinLength(6)]
        [Compare("Password", ErrorMessage = "Not compare password")]
        public string ConfirmPassword { get; set; }        
    }
}
