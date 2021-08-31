using AutoMapper;
using Demo.Application.Common.Mappings;
using Demo.Application.Features.Models.Request;
using Demo.Domain.Entities;

namespace Demo.Application.Features.Models
{
    public class GovermanteResponse : IMapFrom<Government>
    {
        public int id { get; set; }
        public string GovName { get; set; }
   
    }
}
