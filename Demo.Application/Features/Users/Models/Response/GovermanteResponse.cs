using Demo.Application.Common.Mappings;
using Demo.Domain.Entities;

namespace Demo.Application.DTO
{
    public class GovermanteResponse : IMapFrom<Government>
    {
        public int id { get; set; }
        public string GovName { get; set; }

    }
}
