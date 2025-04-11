using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.CQRS.Commands.CategoryCommands;
using MovieApi.Application.Features.CQRS.Handlers.CategoryHandlers;
using MovieApi.Application.Features.CQRS.Handlers.MovieHandlers;
using MovieApi.Application.Features.CQRS.Queries.CategoryQueries;
using MovieApi.Persistence.Context;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
        private readonly GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler;
        private readonly CreateCategoryCommandHandler _categoryCommandHandler;
        private readonly RemoveCategoryCommandHandler _removeCategoryCommandHandler;
        private readonly UpdateCategoryCommandHandler _updateCategoryCommandHandler;

        public CategoriesController(GetCategoryQueryHandler getCategoryQueryHandler, GetCategoryByIdQueryHandler getCategoryByIdQueryHandler, CreateCategoryCommandHandler categoryCommandHandler, RemoveCategoryCommandHandler removeCategoryCommandHandler, UpdateCategoryCommandHandler updateCategoryCommandHandler)
        {
            _getCategoryQueryHandler = getCategoryQueryHandler;
            _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
            _categoryCommandHandler = categoryCommandHandler;
            _removeCategoryCommandHandler = removeCategoryCommandHandler;
            _updateCategoryCommandHandler = updateCategoryCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _getCategoryQueryHandler.Handle();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
        {
            await _categoryCommandHandler.Handle(command);
            return Ok("Create Success");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _removeCategoryCommandHandler.Hanlde(new RemoveCategoryCommand(id));
            return Ok("Delete Success");
        }
        [HttpGet("GetCategoryById")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var value = await _getCategoryByIdQueryHandler.Handle( new GetCategoryByIdQuery(id));
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            await _updateCategoryCommandHandler.Handle(command);
            return Ok("Update Success");
        }
    }
}
