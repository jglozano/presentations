namespace Instrumentation.Registration
{
    using System;
    using System.IO;
    using log4net.Config;
    using MvcTurbine.ComponentModel;

    public class LoggerRegistration : IComponentRegistration
    {
        #region IComponentRegistration Members

        public void Register(IServiceLocator locator)
        {
            Initialize();
            locator.Register<ILogger, DefaultLogger>();
        }

        public static void Initialize()
        {
            string basePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string path = Path.Combine(basePath, "log4net.config");

            XmlConfigurator.ConfigureAndWatch(new FileInfo(path));
        }

        #endregion
    }
}