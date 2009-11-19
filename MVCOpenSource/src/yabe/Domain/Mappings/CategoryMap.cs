using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(cat => cat.Id)
                .GeneratedBy
                .GuidComb();

            Map(cat => cat.Name);
            Map(cat => cat.Description);
            Map(cat => cat.CreatedDate);

            HasManyToMany(cat => cat.Posts)
                .Cascade.All()
                .Inverse()
                .Table("PostCategories")
                .Not.LazyLoad();
        }
    }
}