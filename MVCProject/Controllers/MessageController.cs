using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace MVCProject.Controllers
{
    public class MessageController : Controller
    {
        Context c = new Context();

        Message2Manager m2m = new Message2Manager(new EfMessage2Repository());
        public IActionResult InBox()
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(x => x.Mail == userMail).Select(y => y.ID).FirstOrDefault();
            var values = m2m.GetInboxListByWriter(writerId);
            return View(values);
        }

        [HttpGet]
        public IActionResult SendBox()
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(x => x.Mail == userMail).Select(y => y.ID).FirstOrDefault();
            var values = m2m.GetSendBoxListByWriter(writerId);
            return View(values);
        }

        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            var value = m2m.TGetById(id);
            return View(value);
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message2 msg2)
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(x => x.Mail == userMail).Select(y => y.ID).FirstOrDefault();
            msg2.SenderID = writerId;
            msg2.ReceiverID = 4;
            msg2.Status = true;
            msg2.Date = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            m2m.TAdd(msg2);

            return RedirectToAction("Inbox");
        }
    }
}
