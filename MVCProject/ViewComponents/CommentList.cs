using Microsoft.AspNetCore.Mvc;

namespace MVCProject.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
