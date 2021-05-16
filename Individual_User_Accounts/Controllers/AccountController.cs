using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Individual_User_Accounts.Models;
using Individual_User_Accounts.Models.ViewModel;
using Microsoft.AspNetCore.Identity;

namespace Individual_User_Accounts.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AccountController(SignInManager<User> signInManager, UserManager<User> roleManager)
        {
            _signInManager = signInManager;
            _userManager = roleManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login login)
        {
            if (ModelState.IsValid)
            {
                var res = await _signInManager.PasswordSignInAsync(login.Email, login.Password, false, false);
                if (res.Succeeded)
                {

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Incorrect login or password");
                }
            }
            return View(login);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Register register)
        {
            if (ModelState.IsValid)
            {
                User user = new User() { Email = register.Email, UserName = register.Email };
                var res = await _userManager.CreateAsync(user, register.Password);
                if (res.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Incorrect login or password");
                }
            }
            return View(register);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
