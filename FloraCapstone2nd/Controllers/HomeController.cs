using Microsoft.AspNetCore.Mvc;
using FloraCapstone2nd.Model;
using FloraCapstone2nd.Data;
using FloraCapstone2nd.ViewModel;
using Microsoft.AspNetCore.Identity;

namespace FloraCapstone2nd.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public HomeController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index(string? returnUrl)
        {
            LoginViewModel lvm = new LoginViewModel();
            if(!string.IsNullOrEmpty(returnUrl))
            {
                lvm.ReturnUrl = returnUrl;
            }
            return View(lvm);
        }

        public IActionResult Register()
        {
            return RedirectToAction("Register", "Account");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl)
        {
            User loginUser = await userManager.FindByNameAsync(model.Username);

            if(loginUser!=null)
            {
                var result = await signInManager.PasswordSignInAsync(loginUser, model.Password, false, false);

                if(result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return LocalRedirect(returnUrl);
                    }
                    else
                    {
                        return LocalRedirect("/Home/Login");
                    }
                    
                }
                else
                {
                    ModelState.AddModelError("Login Error", "Credentials Invalid");
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("Login Error", "Credentials Invalid");
                return View(model);
            }

        }
    }
}
