namespace CarMarket.Web
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;
    using CarMarket.Web.Models;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(
               name: "Machine",
               url: "{controller}/{action}/{type}/{id}",
               defaults: new { controller = "Home", action = "ViewDetails", type = UrlParameter.Optional, id = UrlParameter.Optional });

            routes.MapRoute(
               name: "ViewMachine",
               url: "{controller}/{action}/{type}/{id}",
               defaults: new { controller = "Home", action = "ViewMachines", type = UrlParameter.Optional, id = UrlParameter.Optional });

            routes.MapRoute(
              name: "Search",
              url: "{controller}/{action}/{type}/{id}",
              defaults: new { controller = "Home", action = "Searched", type = UrlParameter.Optional, id = UrlParameter.Optional });
        }
    }
}
