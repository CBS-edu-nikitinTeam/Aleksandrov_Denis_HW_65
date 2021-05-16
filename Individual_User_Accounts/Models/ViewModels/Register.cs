using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Individual_User_Accounts.Models.ViewModel
{
    public class Register
    {
        [UIHint("Email")]
        [Required(ErrorMessage = "The email field is empty")]
        public string Email { get; set; }
        [UIHint("Password")]
        [Required(ErrorMessage = "The password field is empty")]
        public string Password { get; set; }
        [UIHint("Password")]
        [Compare("Password", ErrorMessage = "Password entered incorrectly")]
        public string ConfirmPassword { get; set; }
    }
}
