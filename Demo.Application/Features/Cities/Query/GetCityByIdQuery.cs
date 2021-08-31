using Demo.Application.Features.Models;
using MediatR;
using System.Collections.Generic;

namespace Demo.Application.Features.Cities.Query
{
    public class GetCityByIdQuery : IRequest<IEnumerable<CityResponse>>
    {
        public int Id { get; set; }
    }
}
