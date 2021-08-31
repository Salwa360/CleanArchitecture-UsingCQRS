using Demo.Application.Features.Models;
using MediatR;

namespace Demo.Application.Features.Users.Query.GetUserById
{
    public class GetUserByIdQuery:IRequest<UserResponse>
    {
        public int Id { get; set; }
    }
}
