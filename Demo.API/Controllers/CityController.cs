using Demo.API.Controllers.Common;
using Demo.Application.Features.Cities.Query;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class CityController : BaseApiController
    {
        [HttpGet("{id}", Name = "GeCityById")]
        public async Task<IActionResult> GeCityById(int id)
        {
            if (id == 0)
                return BadRequest();
            return Ok(await Mediator.Send(new GetCityByIdQuery { Id = id }));
        }
    }
}
