using MediatR;

namespace Demo.Application.Features.Users.Command.DeleteUser
{
    public class DeleteUserCommand:IRequest
    {
        public int Id { get; set; }
    }
}
