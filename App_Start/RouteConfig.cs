using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Login",
               url: "{controller}",
               defaults: new { controller = "login", action = "Login", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                 name: "Signup",
                 url: "signup",
                 defaults: new { controller = "Signup", action = "Signup" }
            );

            routes.MapRoute(
                  name: "CatchAll",
                 url: "{*url}",
                 defaults: new { controller = "Login", action = "Index" }
             );

            routes.MapRoute(
                 name: "Dashboard",
                url: "{*url}",
                defaults: new { controller = "Dashboard", action = "Index" }
            );
        }
    }
}
