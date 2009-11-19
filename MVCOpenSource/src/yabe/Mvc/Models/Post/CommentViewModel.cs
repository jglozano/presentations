namespace Mvc.Models.Post
{
    using System;

    [Serializable]
    public class CommentViewModel
    {
        public string Author { get; set; }
        public string Text { get; set; }
        public DateTime PostedDate { get; set; }
    }
}
