namespace Mvc.Models.Post
{
    using System;
    using System.Collections.Specialized;
    using System.Web.Mvc;
    using Category;

    public class PostViewModelBinder : IModelBinder
    {
        #region IModelBinder Members

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            if (bindingContext.ModelType != typeof(PostViewModel))
            {
                return null;
            }

            NameValueCollection form = controllerContext.HttpContext.Request.Form;

            string title = form["title"];
            string contents = form["contents"];

            var post = new PostViewModel { Title = title, Contents = contents };

            string catList = form["categories"];

            if (catList != null)
            {
                string[] temp = catList.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                Array.ForEach(temp, categoryid => post.Categories.Add(new CategoryViewModel { Id = new Guid(categoryid) }));
            }

            return post;
        }

        #endregion
    }
}