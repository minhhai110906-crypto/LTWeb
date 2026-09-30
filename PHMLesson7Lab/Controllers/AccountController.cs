using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PHMLesson7Lab.Models;
using System.Security.Principal;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PHMLesson7Lab.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
        private static List<Account> accounts = new List<Account>();
        public ActionResult Index()
        {
            return View(accounts);
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            Account model = new Account();
            return View(model);
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Account account)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(account);
                }
                accounts.Add(account);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(account);
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            var account = accounts.Find(x => x.Id == id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Account account)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(account);
                }

                var index = accounts.FindIndex(x => x.Id == id);
                if (index != -1)
                {
                    accounts[index] = account;
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(account);
            }
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            var account = accounts.Find(x => x.Id == id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                accounts.RemoveAll(x => x.Id == id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyPhone(string phone)
        {
            Regex _isPhone = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if (!_isPhone.IsMatch(phone))
            {
                return Json($"Số điện thoại {phone} Không đúng định dạng, VD: 0986421127 hoặc 098.421.127");
            }

            return Json(true);
        }
    }
}
