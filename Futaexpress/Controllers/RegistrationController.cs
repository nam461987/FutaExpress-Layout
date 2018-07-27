using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Futaexpress.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Personal()
        {
            return View();
        }
        public ActionResult Business()
        {
            return View();
        }
    }
}