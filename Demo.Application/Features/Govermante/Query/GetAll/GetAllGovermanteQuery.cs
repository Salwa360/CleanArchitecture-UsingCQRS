using Demo.Application.Features.Models;
using MediatR;
using System.Collections.Generic;

namespace Demo.Application.Features.Govermante.Query.GetAll
{
    public class GetAllGovermanteQuery : IRequest<IEnumerable<GovermanteResponse>>
    {
    }
}
