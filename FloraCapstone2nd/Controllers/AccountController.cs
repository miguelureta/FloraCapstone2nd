using Microsoft.AspNetCore.Mvc;
using FloraCapstone2nd.ViewModel;

namespace FloraCapstone2nd.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {

            return RedirectToAction("Index", "Home");
        }
        
    }
}
