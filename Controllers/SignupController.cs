using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Models.View_Models;
using TestApp.Services.Services;

namespace TestApp.Controllers
{
    public class SignupController : Controller
    {
        // GET: Register
        public ActionResult Index()
        
        {
            return View("Signup");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Register(SignupModel model)
        {
            SecurityService securityService = new SecurityService();
            var user = securityService.Register(model);
            if (user != null)
            {
                return Json(new { success = true, message = "User registered successfully!", data = user });
            }
            else
            {
                return Json(new { success = false, message = "Registration failed. Please check your username and password." });
            }
        }

    }
}