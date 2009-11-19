using MvcTurbine;
using MvcTurbine.ComponentModel;
using MvcTurbine.Windsor;

namespace Mvc
{
    public class MvcApplication : TurbineApplication
    {
        static MvcApplication()
        {
            ServiceLocatorManager.SetLocatorProvider(() => new WindsorServiceLocator());
        }
    }
}