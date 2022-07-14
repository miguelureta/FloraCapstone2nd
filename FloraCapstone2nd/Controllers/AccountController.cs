using Microsoft.AspNetCore.Mvc;
using FloraCapstone2nd.ViewModel;
using AutoMapper;
using FloraCapstone2nd.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace FloraCapstone2nd.Controllers
{
    public class AccountController : Controller
    {
        //private readonly IMapper mapper;
        private readonly ApplicationDbContext context;
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;

        //Take note of arrangement of parameters when constructing this controller
        public AccountController(UserManager<User> userManager, IMapper mapper, ApplicationDbContext context, SignInManager<User> signInManager)
        {
            //this.mapper = mapper;
            this.context = context;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        //This loads the user registration page
        public new IActionResult RegisterUser()
        {
            return View(new RegisterViewModel());
        }


        //This should trigger validations and if successful, goes to Login screen
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterUser(RegisterViewModel model)
        {

            if(ModelState.IsValid==true)
            {

                //User newUser = mapper.Map<User>(model);
                User newUser = new User();
                newUser.Email = model.Email;
                newUser.UserName = model.Username;
                newUser.SubscriptionID = 0;
                newUser.RoleID = 1;
                
                newUser.DateAdded = DateTime.Now;

                await userManager.CreateAsync(newUser, model.Password);

                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View(model);  
            }
        }
        
    }
}
