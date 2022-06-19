using Microsoft.AspNetCore.Mvc;
using MVCProject.Areas.Admin.Models;
using System.Collections.Generic;

namespace MVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<Category> list = new List<Category>();
            list.Add(new Category { categorycount = 1, categoryname = "Yazılım" });
            list.Add(new Category { categorycount = 5, categoryname = "Bilim" });
            list.Add(new Category { categorycount = 3, categoryname = "Teknoloji" });
            return Json(new { jsonlist = list });
        }
    }
}
