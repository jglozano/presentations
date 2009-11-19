namespace Services
{
    using System;

    [Serializable]
    public class CommentDTO
    {
        public string Author { get; set; }
        public string Text { get; set; }
        public DateTime PostedDate { get; set; }
    }
}