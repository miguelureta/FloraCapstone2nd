using Microsoft.AspNetCore.Mvc;
using FloraCapstone2nd.Model;
using FloraCapstone2nd.Data;

namespace FloraCapstone2nd.Controllers
{
    public class HomeController : Controller
    {
        /*
        private ApplicationDbContext db = new ApplicationDbContext(); 
        */
        public IActionResult Index()
        {
            return View();
        }
    }
}
