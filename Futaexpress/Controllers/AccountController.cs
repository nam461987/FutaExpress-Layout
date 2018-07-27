using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Futaexpress.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Bill_Check()
        {
            return View();
        }
        public ActionResult Bill_History()
        {
            return View();
        }
    }
}