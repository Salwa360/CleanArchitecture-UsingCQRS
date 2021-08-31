using AutoMapper;
using Demo.Application.Common.Contracts;
using Demo.Application.Features.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Application.Features.Users.Query.GetUserById
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserResponse>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationContext _context;
        private ILogger<GetUserByIdHandler> _logger;
        public GetUserByIdHandler(IMapper mapper, IApplicationContext context, ILogger<GetUserByIdHandler> logger)
        {
            _mapper = mapper;
            _context = context;
            _logger = logger;
        }

        public async Task<UserResponse> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
           
            var getUserById = await _context.Users.Include(b => b.Addresses)
                .ThenInclude(x => x.City).ThenInclude(x=>x.Government)
                .Where(x => x.Id == request.Id).SingleOrDefaultAsync();
            if (getUserById == null)
            {
                _logger.LogError("cannot found user");
                throw new System.Exception("Not found");
            }
            
            return _mapper.Map<UserResponse>(getUserById);
        }
    }
}
