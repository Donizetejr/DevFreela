using DevFreela.API.Models;
using DevFreela.Application.Commands.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id }, command);
        }

        [HttpPut("/login")]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            return NoContent();
        }
    }
}
