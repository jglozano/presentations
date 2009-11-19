using FluentNHibernate.Mapping;

namespace domain.Mappings
{
    public class AddressMap : ClassMap<Address>
    {
        public AddressMap()
        {
            Id(addr => addr.Id);
            Map(addr => addr.Line1);
            Map(addr => addr.Line2);

            Map(addr => addr.City);
            Map(addr => addr.State);
            Map(addr => addr.Zip);
        }
    }
}