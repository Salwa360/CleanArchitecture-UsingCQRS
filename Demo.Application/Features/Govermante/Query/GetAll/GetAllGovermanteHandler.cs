using AutoMapper;
using Demo.Application.Common.Contracts;
using Demo.Application.Features.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Application.Features.Govermante.Query.GetAll
{
    public class GetGovermanteByIdHandler : IRequestHandler<GetAllGovermanteQuery, IEnumerable<GovermanteResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationContext _context;

        public GetGovermanteByIdHandler(IMapper mapper, IApplicationContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<IEnumerable<GovermanteResponse>> Handle(GetAllGovermanteQuery request, CancellationToken cancellationToken)
        {
            var getAllGovernmante = await _context.Govermantes.
              Include(b => b.Cities).ToListAsync();

            return _mapper.Map<List<GovermanteResponse>>(getAllGovernmante);
        }
    }
}
