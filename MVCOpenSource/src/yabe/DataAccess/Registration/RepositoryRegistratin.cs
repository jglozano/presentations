namespace DataAccess.Registration
{
    using MvcTurbine.ComponentModel;

    public class RepositoryRegistration : IComponentRegistration
    {
        #region IComponentRegistration Members

        public void Register(IServiceLocator locator)
        {
            locator.Register<ICategoryRepository, CategoryRepository>();
            locator.Register<ICommentRepository, CommentRepository>();
            locator.Register<IPostRepository, PostRepository>();
        }

        #endregion
    }
}