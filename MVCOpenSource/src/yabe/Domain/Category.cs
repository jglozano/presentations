using System;
using System.Collections.Generic;

namespace Domain
{
    [Serializable]
    public class Category : EntityBase
    {
        public Category()
        {
            Posts = new List<Post>();
        }

        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime CreatedDate { get; set; }

        public virtual IList<Post> Posts { get; set; }
    }
}