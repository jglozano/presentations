using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
    public class CommentMap : ClassMap<Comment>
    {
        public CommentMap()
        {
            Id(comment => comment.Id)
                .GeneratedBy
                .GuidComb();

            Map(comment => comment.Author);
            Map(comment => comment.Text);
            Map(comment => comment.PostedDate);
        }
    }
}