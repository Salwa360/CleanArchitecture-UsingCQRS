using AutoMapper;
using Demo.Application.Common.Contracts;
using Demo.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Application.Features.Users.Command.UpdateUser
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, string>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationContext _context;
        private ILogger<UpdateUserHandler> _logger = null;
        public UpdateUserHandler(IMapper mapper, IApplicationContext context, ILogger<UpdateUserHandler> logger)
        {
            _mapper = mapper;
            _context = context;
            _logger = logger;
        }

        public async Task<string> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var user = _mapper.Map<User>(request);
                _context.Users.Update(user);

                foreach (var item in request.UserAddress)
                {
                    var address = _mapper.Map<Address>(item);
                    if (item.Id != 0)
                        _context.Addresses.Update(address);
                    
                    else
                        user.Addresses.Add(address);
                }

                await _context.SaveChangesAsync();

                return "Update Successfully";

            }
            catch (System.Exception ex)
            {
                _logger.LogError("cannot be updated : {0}", ex.InnerException);
                return "Can not Updated";
            }
        }
    }
}
