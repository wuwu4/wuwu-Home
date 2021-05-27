using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using prjProductSys.Models;
using System.Web.Security;

namespace prjProductSys.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string 帳號, string 密碼)
        {
            dbProductEntities db = new dbProductEntities();
            var member = db.會員
                .Where(m => m.帳號 == 帳號 && m.密碼 == 密碼)
                .FirstOrDefault();
            if (member != null)
            {
                FormsAuthentication.RedirectFromLoginPage
                    (member.帳號, true);
                return RedirectToAction("Index", "Category");
            }
            ViewBag.IsLogin = true;
            return View();
        }
    }
}