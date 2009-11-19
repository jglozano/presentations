namespace MvcApplication {
    using MvcTurbine.ComponentModel;
    using MvcTurbine.Web;
    using MvcTurbine.Windsor;

    public class MvcApplication : TurbineApplication {
        static MvcApplication() {
            // Register the IoC that you want Mvc Turbine to use!
            // Everything else is wired automatically

            // For now, let's use the Castle Windsor IoC
            ServiceLocatorManager.SetLocatorProvider(() => new WindsorServiceLocator());
        }
    }
}