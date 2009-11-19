namespace Services
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public class PostDTO
    {
        public PostDTO()
        {
            Categories = new List<CategoryDTO>();
            Comments = new List<CommentDTO>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime PostedDate { get; set; }
        public IList<CategoryDTO> Categories { get; set; }
        public IList<CommentDTO> Comments { get; set; }
    }
}