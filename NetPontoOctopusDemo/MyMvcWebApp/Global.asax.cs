using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyMvcWebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static readonly Version Version = typeof (MvcApplication).Assembly.GetName().Version;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
