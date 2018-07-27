using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Futaexpress
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Branch",
                url: "he-thong-chi-nhanh.html",
                defaults: new { controller = "Home", action = "Branch" }
            );
            routes.MapRoute(
                name: "Personal",
                url: "ca-nhan-dang-ky.html",
                defaults: new { controller = "Registration", action = "Personal" }
            );
            routes.MapRoute(
                name: "Business",
                url: "doanh-nghiep-dang-ky.html",
                defaults: new { controller = "Registration", action = "Business" }
            );
            routes.MapRoute(
                name: "AppLandingPage",
                url: "app-landing-page.html",
                defaults: new { controller = "Home", action = "AppLandingPage" }
            );
            routes.MapRoute(
                name: "Contact",
                url: "lien-he.html",
                defaults: new { controller = "Home", action = "Contact" }
            );
            routes.MapRoute(
                name: "Bill_Create",
                url: "tao-don-hang.html",
                defaults: new { controller = "Bill", action = "Bill_Create" }
            );
            routes.MapRoute(
                name: "Bill_History",
                url: "lich-su-giao-nhan.html",
                defaults: new { controller = "Account", action = "Bill_History" }
            );
            routes.MapRoute(
                name: "Bill_Check",
                url: "kiem-tra-don-hang.html",
                defaults: new { controller = "Account", action = "Bill_Check" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
