using System;
using System.Collections.Generic;

namespace Domain
{
    [Serializable]
    public class Post : EntityBase
    {
        public Post()
        {
            Categories = new List<Category>();
            Comments = new List<Comment>();
        }

        public virtual string Title { get; set; }
        public virtual string Contents { get; set; }
        public virtual DateTime PostedDate { get; set; }
        public virtual IList<Category> Categories { get; set; }
        public virtual IList<Comment> Comments { get; set; }


        public virtual void AddCategory(Category category)
        {
            if (category == null)
            {
                return;
            }

            Categories.Add(category);
        }

        public virtual void AddComment(Comment comment)
        {
            if (comment == null)
            {
                return;
            }
            Comments.Add(comment);
        }
    }
}