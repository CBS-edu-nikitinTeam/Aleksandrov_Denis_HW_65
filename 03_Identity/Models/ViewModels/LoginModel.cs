using System.ComponentModel.DataAnnotations;

namespace _03_Identity.Models.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Не указан Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [UIHint("Password")]
        public string Password { get; set; }
    }
}
