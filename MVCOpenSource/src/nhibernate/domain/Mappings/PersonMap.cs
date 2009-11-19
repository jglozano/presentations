using FluentNHibernate.Mapping;

namespace domain.Mappings
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Id(p => p.Id);
            Map(p => p.FirstName);
            Map(p => p.MiddleName);
            Map(p => p.LastName);

            References(p => p.Address).Not.LazyLoad();
        }
    }
}