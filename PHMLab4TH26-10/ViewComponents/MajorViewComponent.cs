using Microsoft.AspNetCore.Mvc;
using PHMLab4TH26_10.Data; 
using PHMLab4TH26_10.Models;

namespace PHMLab4TH26_10.ViewComponents
{
    public class MajorViewComponent : ViewComponent
    {
        SchoolContext db;
        List<Major> majors;

        public MajorViewComponent(SchoolContext _context)
        {
            db = _context;
            majors = db.Majors.ToList();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderMajor", majors);
        }
    }
}