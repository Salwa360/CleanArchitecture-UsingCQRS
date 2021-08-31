using AutoMapper;
using Demo.Application.Common.Mappings;
using Demo.Domain.Entities;

namespace Demo.Application.Features.Models.Request
{
    public class AddressRequest:IMapFrom<Address>
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public int FlatNumber { get; set; }
        public int UserId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Address, AddressRequest>().ForMember(dest => dest.UserId,
                        opt => opt.MapFrom(src => src.UserId))
                .ReverseMap();
        }
    }
}
