using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ScienceAndCiao
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            ////older convention way to do custom routes - the newer is attribute routing
            //routes.MapRoute(
            //    "KitsByReleaseDate",
            //    "kit/released/{year}/{month}",
            //    new { controller = "Kit", action = "ByReleaseDate" },
            //    //must be 4 digits year and 2 digits month
            //    new { year = @"\d{4}", month = @"\d{2}"});
            ////new { year = @"2019|2020", month = @"\d{2}"});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
