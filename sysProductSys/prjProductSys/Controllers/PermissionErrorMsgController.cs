using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjProductSys.Controllers
{
    public class PermissionErrorMsgController : Controller
    {
        // GET: PermissionErrorMsg
        public ActionResult Index(string msg)
        {
            ViewBag.ErrorMsg = msg;
            return View();
        }
    }
}