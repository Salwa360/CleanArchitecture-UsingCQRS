using Demo.Application.Common.Mappings;
using Demo.Domain.Entities;

namespace Demo.Application.Features.Users.Models
{
    public class AddressResponse : IMapFrom<Address>
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public int FlatNumber { get; set; }
    }
}
