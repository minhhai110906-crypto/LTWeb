using Microsoft.AspNetCore.Mvc;
using PHMLesson7.Models;

namespace PHMLesson7.Controllers
{
    public class MemberController : Controller
    {
        private static List<Member> phmMembers = new List<Member>();
        public IActionResult Index()
        {
            return View(phmMembers);
        }
        public IActionResult Details(int id)
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Member phmMember)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    
                    return View(phmMember);
                }
                phmMembers.Add(phmMember);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(phmMember);
            } 
        }
    }
}
