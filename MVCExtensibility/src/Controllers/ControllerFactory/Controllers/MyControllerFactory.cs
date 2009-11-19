namespace ControllerFactory.Controllers
{
    using System.Web.Mvc;

    public class MyControllerFactory : DefaultControllerFactory
    {
        private static readonly IMessageProvider defaultProvider = new DefaultMessageProvider();

        protected override IController GetControllerInstance(System.Type controllerType)
        {
            if (controllerType == typeof(FooController))
            {
                return new MyController(defaultProvider);
            }

            var controller = base.GetControllerInstance(controllerType);
            return controller;
        }

        protected override System.Type GetControllerType(string controllerName)
        {
            if (controllerName.Contains("foo")) return typeof(FooController);

            var otherType = base.GetControllerType(controllerName);
            return otherType;
        }
    }
}
