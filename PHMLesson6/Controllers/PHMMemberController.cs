using Microsoft.AspNetCore.Mvc;
using PHMLesson6.Models;

namespace PHMLesson6.Controllers
{
    public class PHMMemberController : Controller
    {
        private static readonly List<PHMMember> _phmMembers = new List<PHMMember>()
        {
                new PHMMember() {
                    PHMMemberId = Guid.NewGuid().ToString(),
                    PHMMemberUserName = "haiminh01",
                    PHMMemberPassword = "123",
                    PHMMemberEmail = "minhhai110906@gmail.com",
                    PHMMemberFullName = "Phạm Hải Minh"
                },
                new PHMMember() {
                    PHMMemberId = Guid.NewGuid().ToString(),
                    PHMMemberUserName = "vananh02",
                    PHMMemberPassword = "123",
                    PHMMemberEmail = "vananh@gmail.com",
                    PHMMemberFullName = "Nguyễn Vân Anh"
                },
                new PHMMember() {
                    PHMMemberId = Guid.NewGuid().ToString(),
                    PHMMemberUserName = "hoangnam03",
                    PHMMemberPassword = "123",
                    PHMMemberEmail = "nam@gmail.com",
                    PHMMemberFullName = "Trần Hoàng Nam"
                },
                new PHMMember() {
                    PHMMemberId = Guid.NewGuid().ToString(),
                    PHMMemberUserName = "thiphuong04",
                    PHMMemberPassword = "123",
                    PHMMemberEmail = "phuong@gmail.com",
                    PHMMemberFullName = "Lê Thị Phương"
                },
                new PHMMember() {
                    PHMMemberId = Guid.NewGuid().ToString(),
                    PHMMemberUserName = "ducthanks05",
                    PHMMemberPassword = "123",
                    PHMMemberEmail = "duc@gmail.com",
                    PHMMemberFullName = "Vũ Minh Đức"
                }
        };
        // GET: List
        public IActionResult PHMIndex()
        {
            return View(_phmMembers);
        }
        /// <summary>
        /// Create
        /// </summary>
        /// <returns></returns>
        public IActionResult PHMCreate()
        {
            return View();
        }
        /// <summary>
        /// Create - submit form
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PHMCreate(PHMMember phmMember)
        {
            phmMember.PHMMemberId = Guid.NewGuid().ToString();
            _phmMembers.Add(phmMember);
            return RedirectToAction("PHMIndex");
        }
        /// <summary>
        /// PHMEdit
        /// </summary>
        /// <returns></returns>
        public IActionResult PHMEdit(string id)
        {
            var phmMember = _phmMembers.FirstOrDefault(x=>x.PHMMemberId.Equals(id));
            return View(phmMember);
        }
        /// <summary>
        /// Edit - submit form
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PHMEdit(string id, PHMMember phmMember)
        {
            for(int i = 0; i < _phmMembers.Count; i++)
            {
                if (_phmMembers[i].PHMMemberId == id)
                {
                    _phmMembers[i].PHMMemberId = phmMember.PHMMemberId;
                    _phmMembers[i].PHMMemberUserName = phmMember.PHMMemberUserName;
                    _phmMembers[i].PHMMemberPassword = phmMember.PHMMemberPassword;
                    _phmMembers[i].PHMMemberFullName = phmMember.PHMMemberFullName;
                    _phmMembers[i].PHMMemberEmail = phmMember.PHMMemberEmail;
                    break;
                } 
            }
            return RedirectToAction("PHMIndex");
        }
        public IActionResult PHMGetDetails()
        {
            var phmmember = new PHMMember()
            {
                PHMMemberId = Guid.NewGuid().ToString(),
                PHMMemberUserName = "Hải Minh",
                PHMMemberPassword = "minh123@",
                PHMMemberFullName = "Phạm Hải Minh",
                PHMMemberEmail = "minhhai110906@gmail.com"
            };
            return View(phmmember);
        }
    }
}
