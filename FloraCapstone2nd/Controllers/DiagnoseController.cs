using Microsoft.AspNetCore.Mvc;
using FloraCapstone2nd.Model;
using FloraCapstone2nd.Data;

namespace FloraCapstone2nd.Controllers
{
    public class DiagnoseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View(new Diagnose());
        }

    }
}
