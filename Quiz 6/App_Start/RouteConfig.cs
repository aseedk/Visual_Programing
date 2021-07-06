using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Quiz_6
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            );
            routes.MapRoute(
                name: "Add",
                url: "standard/{action}/{i}/{j}",
                defaults: new { controller = "Home", action = "Add", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "sub",
                url: "standard/{action}/{i}/{j}",
                defaults: new { controller = "Home", action = "Sub", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Multiply",
                url: "standard/{action}/{i}/{j}",
                defaults: new{controller = "Home", action = "Mul", id = UrlParameter.Optional}
            );
            routes.MapRoute(
                name: "Div",
                url: "standard/{action}/{i}/{j}",
                defaults: new { controller = "Home", action = "Div", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Pow",
                url: "standard/{action}/{i}/{j}",
                defaults: new { controller = "Home", action = "Pow", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Mod",
                url: "standard/{action}/{i}/{j}",
                defaults: new { controller = "Home", action = "Mod", id = UrlParameter.Optional }
            );
        }
    }
}