﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Futaexpress.Controllers
{
    public class BillController : Controller
    {
        // GET: Bill
        public ActionResult Bill_Create()
        {
            return View();
        }
    }
}