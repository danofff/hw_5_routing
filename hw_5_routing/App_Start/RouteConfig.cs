using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace hw_5_routing
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

           /* routes.MapRoute(
                name: "ServiceHistoryHome",
                url: "Home/Index/?year={year}/&month={month}/&day={day}",
                defaults: new { controller = "Home", action = "Index", year = UrlParameter.Optional, month = UrlParameter.Optional, day = UrlParameter.Optional }
            );*/

            /*routes.MapRoute(
                name: "ServiceHistoryTrack",
                url: "{controller}/{action}/{year}/{month}/{day}",
                defaults: new { controller = "TrackServiceHistory", action = "Index", year = UrlParameter.Optional, month=UrlParameter.Optional,day=UrlParameter.Optional }
            );*/


        }
    }
}
