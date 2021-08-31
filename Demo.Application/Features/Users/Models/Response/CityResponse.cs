using AutoMapper;
using Demo.Application.Common.Mappings;
using Demo.Domain.Entities;

namespace Demo.Application.DTO
{
    public class CityResponse : IMapFrom<City>
    {
        public int id { get; set; }
        public string CityName { get; set; }

    }
}
