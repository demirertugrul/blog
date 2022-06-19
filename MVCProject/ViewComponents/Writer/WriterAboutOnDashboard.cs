using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MVCProject.ViewComponents.Writer
{
    public class WriterAboutOnDashboard
    : ViewComponent
    {
        WriterManager vm = new WriterManager(new EfWriterRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var userName = User.Identity.Name;
            ViewBag.v = userName;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(x => x.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.Mail == userMail).Select(z => z.ID).FirstOrDefault();
            var values = vm.GetWriterByID(writerID);
            return View(values);
        }
    }
}
