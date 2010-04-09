namespace MvcTurbine.Samples.ControllerInjection {
    using ComponentModel;
    using Microsoft.Practices.Unity;
    using Services;
    using Services.Impl;
    using Unity;
    using Web;

    public class MvcApplication : TurbineApplication {
        static MvcApplication() {
            // Register the IoC that you want Mvc Turbine to use!
            // Everything else is wired automatically

            // For now, let's use the Unity IoC
            ServiceLocatorManager.SetLocatorProvider(() => new UnityServiceLocator(CreateContainer()));
        }

        static IUnityContainer CreateContainer() {
            var container = new UnityContainer();
            container.RegisterInstance<IMessageService>(new MessageService());
            return container;
        }
    }
}
