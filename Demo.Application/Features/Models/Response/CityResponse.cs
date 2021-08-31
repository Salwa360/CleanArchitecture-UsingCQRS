
using Demo.Application.Common.Mappings;
using Demo.Domain.Entities;

namespace Demo.Application.Features.Models
{
    public class CityResponse : IMapFrom<City>
    {
        public int id { get; set; }
        public string CityName { get; set; }
        public int GovernmentId { get; set; }

    }
}
