namespace Mvc.Models.Post
{
    using System;
    using System.Collections.Generic;
    using Category;
    using System.ComponentModel.DataAnnotations;

    [Serializable]
    public class PostViewModel
    {
        public PostViewModel()
        {
            Categories = new List<CategoryViewModel>();
            Comments = new List<CommentViewModel>();
        }

        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Contents { get; set; }
        public DateTime PostedDate { get; set; }
        public IList<CategoryViewModel> Categories { get; set; }
        public IList<CommentViewModel> Comments { get; set; }
    }
}