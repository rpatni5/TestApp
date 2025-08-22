using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Models;
using TestApp.Services.Services;

namespace TestApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }

        public JsonResult Login(UserModel model)
        {
            SecurityService securityService = new SecurityService();
            var user = securityService.Authenticate(model);

            if (user != null)
            {
                return Json(new { success = true, message = "Login successful!", data = user });
            }
            else
            {
                return Json(new { success = false, message = "Login failed. Please check your username and password."});
            }
        }
    }
}