namespace Services.Registration
{
    using MvcTurbine.ComponentModel;

    public class ServiceRegistration : IComponentRegistration
    {
        #region IComponentRegistration Members

        public void Register(IServiceLocator locator)
        {
            locator.Register<ICategoryService, CategoryService>();
            locator.Register<IPostService, PostService>();
        }

        #endregion
    }
}