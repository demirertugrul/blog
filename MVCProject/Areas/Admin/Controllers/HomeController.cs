using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
