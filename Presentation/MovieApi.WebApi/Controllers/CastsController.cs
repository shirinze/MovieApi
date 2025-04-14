using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.Mediator.Commands.CastCommands;
using MovieApi.Application.Features.Mediator.Queries.CastQueries;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastsController : ControllerBase
    {
        private readonly IMediator _meditor;

        public CastsController(IMediator meditor)
        {
            _meditor = meditor;
        }
        [HttpGet]
        public async Task<IActionResult> CastList()
        {
            var value = await _meditor.Send(new GetCastQuery());
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCast(CreateCastCommand command)
        {
            await _meditor.Send(command);
            return Ok("Create Success");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveCast(int id)
        {
            await _meditor.Send(new RemoveCastCommand(id));
            return Ok("Remove Success");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCast(UpdateCastCommand command)
        {
            await _meditor.Send(command);
            return Ok("Update Success");

        }
        [HttpGet("GetCastById")]
        public async Task<IActionResult> GetCastById(int id)
        {
            var value=await _meditor.Send(new GetCastByIdQuery(id));
            return Ok(value);
        }
    }
}
