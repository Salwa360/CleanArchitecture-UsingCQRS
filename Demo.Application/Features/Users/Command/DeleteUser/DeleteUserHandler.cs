using Demo.Application.Common.Contracts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Application.Features.Users.Command.DeleteUser
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand>
    {
       
        private readonly IApplicationContext _context;
        private ILogger<DeleteUserHandler> _logger;

        public DeleteUserHandler( IApplicationContext context, ILogger<DeleteUserHandler> logger)
        {
         
            _context = context;
            _logger = logger;
        }

    
         async Task<Unit> IRequestHandler<DeleteUserCommand, Unit>.Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var user = _context.Users.Include(b => b.Addresses).FirstOrDefault(x => x.Id == request.Id);
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
            catch (System.Exception ex)
            {
                _logger.LogError("cannot be deleted : {0}", ex.InnerException);
                throw new System.Exception( "cannot Deleted");
            }
        }
    }
}
