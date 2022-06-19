using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MVCProject.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        Context c = new Context();
        Message2Manager m2m = new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(x => x.Mail == userMail).Select(y => y.ID).FirstOrDefault();
            var values = m2m.GetInboxListByWriter(writerId);
            return View(values);
        }
    }
}
