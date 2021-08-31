using AutoMapper;
using Demo.Application.Common.Contracts;
using Demo.Application.Features.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Application.Features.Users.Query.GetAllUser
{
    public class GetAllUserHandler : IRequestHandler<GetAllUserQuery, IEnumerable<UserResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationContext _context;
        private ILogger<GetAllUserHandler> _logger = null;
        public GetAllUserHandler(IMapper mapper, IApplicationContext context, ILogger<GetAllUserHandler> logger)
        {
            _mapper = mapper;
            _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<UserResponse>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var userWithAddress = await _context.Users.
                Include(b => b.Addresses).ThenInclude(x => x.City).ToListAsync();

            return _mapper.Map<List<UserResponse>>(userWithAddress);
        }
    }
}
