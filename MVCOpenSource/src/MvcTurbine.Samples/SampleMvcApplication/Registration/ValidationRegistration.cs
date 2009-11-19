namespace SampleMvcApplication.Registration
{
    using Models;
    using MvcTurbine.ComponentModel;

    public class ValidationRegistration : IComponentRegistration
    {
        #region IComponentRegistration Members

        public void Register(IServiceLocator locator)
        {
            locator.Register<IModelValidator, FooValidator>();
        }

        #endregion
    }
}