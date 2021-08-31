using AutoMapper;
using Demo.Application.Common.Contracts;
using Demo.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Application.Features.Users.Command.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationContext _context;
        private ILogger<CreateUserHandler> _logger = null;

        public CreateUserHandler(IMapper mapper, IApplicationContext context, ILogger<CreateUserHandler> logger)
        {
            _mapper = mapper;
            _context = context;
            _logger = logger;
        }
       
        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var user = _mapper.Map<User>(request);
                    await _context.Users.AddAsync(user);

                    if (request.UserAddress != null)
                    {
                        foreach (var add in request.UserAddress)
                        {
                            var address = _mapper.Map<Address>(add);
                            user.Addresses.Add(address);
                        }
                    }

                    await _context.SaveChangesAsync();

                    return user.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError("cannot be added : {0}", ex.InnerException);
                throw new Exception("can not inserted");
               
            }

        }
    }
}
