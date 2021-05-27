using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using prjProductSys.Models;

namespace prjProductSys.Controllers
{
    public class MobileController : Controller
    {
        dbProductEntities db = new dbProductEntities();
        // GET: Mobile
        public ActionResult Index()
        {
            var category = from c in db.產品類別
                           join p in db.產品資料
                           on c.類別編號 equals p.類別編號
                           into t
                           select new 產品類別統計ViewModel
                           {
                               類別編號 = c.類別編號,
                               類別名稱 = c.類別名稱,
                               數量 = t.Count()
                           };
            return View(category);
        }

        public ActionResult Products(int cid)
        {
            ViewBag.CategoryName = db.產品類別
                .Where(m => m.類別編號 == cid)
                .FirstOrDefault()
                .類別名稱;

            var products = db.產品資料
                .Where(m => m.類別編號 == cid)
                .OrderByDescending(m => m.修改日)
                .ToList();
            return View(products);
        }
    }
}