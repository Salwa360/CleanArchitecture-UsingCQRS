using AutoMapper;
using Demo.Application.Common.Contracts;
using Demo.Application.Features.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Application.Features.Cities.Query
{
    public class GetCityByIdHandler : IRequestHandler<GetCityByIdQuery, IEnumerable<CityResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationContext _context;

        public GetCityByIdHandler(IMapper mapper, IApplicationContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        async Task<IEnumerable<CityResponse>> IRequestHandler<GetCityByIdQuery, IEnumerable<CityResponse>>.Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
        {
            var cityById = await _context.Cities
             .Where(x => x.GovernmentId == request.Id).ToListAsync();
            return _mapper.Map<IEnumerable<CityResponse>>(cityById);
        }
    }
}
