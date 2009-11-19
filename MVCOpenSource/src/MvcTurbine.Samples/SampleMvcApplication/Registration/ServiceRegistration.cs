namespace SampleMvcApplication.Registration
{
    using MvcTurbine.ComponentModel;
    using Services;
    using Services.Impl;

    public class ServiceRegistration : IComponentRegistration
    {
        #region IComponentRegistration Members

        public void Register(IServiceLocator locator)
        {
            locator.Register<IMessageService, MessageService>();
            locator.Register<IFormsAuthentication, FormsAuthenticationService>();
            locator.Register<IMembershipService, AccountMembershipService>();
        }

        #endregion
    }
}