using MvcTurbine.ComponentModel;
using Services;

namespace Mvc.Registration
{
    public class ServiceRegistration : IComponentRegistration
    {
        #region IComponentRegistration Members

        public void Register(IServiceLocator locator)
        {
            locator.Register<IPostService, PostService>();
            locator.Register<ICategoryService, CategoryService>();
        }

        #endregion
    }
}