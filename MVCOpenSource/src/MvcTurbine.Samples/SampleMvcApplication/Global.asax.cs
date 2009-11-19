namespace SampleMvcApplication
{
    using MvcTurbine;
    using MvcTurbine.ComponentModel;
    using MvcTurbine.Windsor;

    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : TurbineApplication
    {
        static MvcApplication()
        {
            // Register the IoC that you want Mvc Turbine to use!
            // Everything else is wired automatically
            ServiceLocatorManager.SetLocatorProvider(() => new WindsorServiceLocator());
        }
    }
}
