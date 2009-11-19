namespace SampleMvcApplication.Filters
{
    using System.Web.Mvc;

    public class CustomExceptionFilter : IExceptionFilter
    {
        #region IExceptionFilter Members

        public void OnException(ExceptionContext filterContext)
        {
        }

        #endregion
    }
}