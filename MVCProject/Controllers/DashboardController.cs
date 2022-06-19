using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MVCProject.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            Context c = new Context();
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(x => x.Email).FirstOrDefault();
            var writerId = c.Writers.Where(x => x.Mail == userMail).Select(y => y.ID).FirstOrDefault();

            ViewBag.ToplamBlogSayisi = bm.TGetAll().Count;
            ViewBag.WriterBlogSayisi = bm.GetBlogListByWriter(writerId).Count;
            ViewBag.CategorySayisi = cm.TGetAll().Count;
            return View();
        }
    }
}
