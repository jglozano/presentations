using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
    public class PostMap : ClassMap<Post>
    {
        public PostMap()
        {
            Id(post => post.Id)
                .GeneratedBy
                .GuidComb();

            Map(post => post.Title);
            Map(post => post.Contents);
            Map(post => post.PostedDate);

            HasManyToMany(post => post.Categories)
                .Cascade.All()
                .Table("PostCategories")
                .Not.LazyLoad();

            HasMany(post => post.Comments)
                .Table("PostComments")
                .Inverse()
                .Cascade.All()
                .Not.LazyLoad();
        }
    }
}
