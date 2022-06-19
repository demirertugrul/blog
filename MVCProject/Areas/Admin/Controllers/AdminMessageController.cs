using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace MVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminMessageController : Controller
    {
        Context c = new Context();

        Message2Manager m2m = new Message2Manager(new EfMessage2Repository());
        public IActionResult InBox()
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(x => x.Mail == userMail).Select(y => y.ID).FirstOrDefault();
            var values = m2m.GetInboxListByWriter(writerId);
            ViewBag.MesajSayisi = m2m.TGetAll().Count;
            return View(values);
        }
        public IActionResult SendBox()
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(x => x.Mail == userMail).Select(y => y.ID).FirstOrDefault();
            var values = m2m.GetSendBoxListByWriter(writerId);
            return View(values);
        }
        [HttpGet]
        public IActionResult ComposeMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ComposeMessage(Message2 p)
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(x => x.Mail == userMail).Select(y => y.ID).FirstOrDefault();
            p.SenderID = writerId;
            p.ReceiverID = 2;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            m2m.TAdd(p);
            return RedirectToAction("Sendbox");
        }
    }
}
