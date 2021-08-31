using Demo.API.Controllers.Common;
using Demo.Application.Features.Models;
using Demo.Application.Features.Users.Command.CreateUser;
using Demo.Application.Features.Users.Command.DeleteUser;
using Demo.Application.Features.Users.Command.UpdateUser;
using Demo.Application.Features.Users.Query.GetAllUser;
using Demo.Application.Features.Users.Query.GetUserById;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class UserController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserResponse>>> GetAllUsers()
        {
            return Ok(await Mediator.Send(new GetAllUserQuery()));
        }
        [HttpGet("{id}", Name = "GetUserById")]
        public async Task<IActionResult> GetUserById(int id)
        {
            if (id == 0)
                return BadRequest();
           
            return Ok(await Mediator.Send(new GetUserByIdQuery { Id = id }));
        }
        [HttpPost(Name = "Create")]
        public async Task<ActionResult<int>> CreateUser([FromBody] CreateUserCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
        [HttpPut("{id:int}", Name = "Update")]
        public async Task<IActionResult> UpdateUser(int id, UpdateUserCommand command)
        {
            if (id != command.Id)
                return NotFound();
            if (id == 0)
                    return BadRequest();

            return Ok(await Mediator.Send(command));
        }
        [HttpDelete("{id}", Name = "delete")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (id == 0)
                return BadRequest();
            return Ok(await Mediator.Send(new DeleteUserCommand { Id = id }));
        }
    }

}

