using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.Mediator.Commands;
using MovieApi.Application.Features.Mediator.Commands.TagCommands;
using MovieApi.Application.Features.Mediator.Queries.TagQueries;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly IMediator _meditor;

        public TagsController(IMediator meditor)
        {
            _meditor = meditor;
        }

        [HttpGet]
        public async Task<IActionResult> TagList()
        {
            var value = await _meditor.Send(new GetTagQuery());
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagCommand command)
        {
            await _meditor.Send(command);
            return Ok("Create Success");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveTag(int id)
        {
            await _meditor.Send(new RemoveTagCommand(id));
            return Ok("Remove Success");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTag(UpdateTagCommand command)
        {
            await _meditor.Send(command);
            return Ok("Update Success");

        }
        [HttpGet("GetTagById")]
        public async Task<IActionResult> GetTagById(int id)
        {
            var value = await _meditor.Send(new GetTagByIdQuery(id));
            return Ok(value);
        }
    }
}
