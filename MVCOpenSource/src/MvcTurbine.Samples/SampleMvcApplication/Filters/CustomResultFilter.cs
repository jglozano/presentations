namespace SampleMvcApplication.Filters
{
    using System;
    using System.Web.Mvc;

    public class CustomResultFilter : IResultFilter
    {
        #region IResultFilter Members

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}