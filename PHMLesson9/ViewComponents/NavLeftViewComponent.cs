using Microsoft.AspNetCore.Mvc;

namespace PHMLesson9.ViewComponents
{
    public class NavLeftViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
