using System.ComponentModel.DataAnnotations;

namespace _03_Identity.Models.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указан Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указана страна проживания!")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [UIHint("Password")]
        public string Password { get; set; }

        [UIHint("Password")]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }
    }
}
