using Demo.API.Controllers.Common;
using Demo.Application.Features.Govermante.Query.GetAll;
using Demo.Application.Features.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class GovermanteController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GovermanteResponse>>> GetAllGovermante()
        {
            return Ok(await Mediator.Send(new GetAllGovermanteQuery()));
        }
       
    }
}
