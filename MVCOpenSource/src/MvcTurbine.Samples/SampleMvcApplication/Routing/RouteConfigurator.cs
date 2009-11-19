namespace SampleMvcApplication.Routing
{
    using System.Web.Mvc;
    using System.Web.Routing;
    using MvcTurbine.Routing;

    public class RouteConfigurator : IRouteConfigurator
    {
        #region IRouteConfigurator Members

        public void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Default",
                            "{controller}/{action}/{id}",
                            new { controller = "Home", action = "Index", id = "" });
        }

        #endregion
    }
}