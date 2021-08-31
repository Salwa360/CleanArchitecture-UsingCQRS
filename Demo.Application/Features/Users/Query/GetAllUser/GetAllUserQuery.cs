using Demo.Application.Features.Models;
using MediatR;
using System.Collections.Generic;

namespace Demo.Application.Features.Users.Query.GetAllUser
{
    public class GetAllUserQuery:IRequest <IEnumerable<UserResponse>>
    {

    }
}
