namespace Mvc.Registration
{
    using System.Web.Mvc;
    using System.Web.Routing;
    using MvcTurbine.Routing;

    public class RouteRegistration : IRouteConfigurator
    {
        #region IRouteConfigurator Members

        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("posts", "posts/{action}/{id}",
                            new {controller = "post", action = "index", id = ""});

            routes.MapRoute("categories", "categories/{action}/{id}",
                            new {controller = "category", action = "list", id = ""});

            routes.MapRoute("standard", "{controller}/{action}/{id}",
                            new {controller = "post", action = "index", id = (string) null});

            routes.MapRoute("default_aspx", "Default.aspx", new {controller = "post", action = "index"});
        }

        #endregion
    }
}