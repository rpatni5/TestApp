﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApp.Controllers
{
    public class ErrorController : Controller
    {
         public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult General()
        {
            return View();
        }
    }
}