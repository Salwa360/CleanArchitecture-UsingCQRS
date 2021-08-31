using AutoMapper;
using Demo.Application.Common.Mappings;
using Demo.Domain.Entities;

namespace Demo.Application.Features.Models
{
    public class AddressResponse : IMapFrom<Address>
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int GovernmentId { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public int FlatNumber { get; set; }
         public void Mapping(Profile profile)
        {

            profile.CreateMap<Address,AddressResponse>()
                .ForMember(dest => dest.GovernmentId,
                        opt => opt.MapFrom(src => src.City.GovernmentId))
                .ReverseMap();
        }
       


    }
}
