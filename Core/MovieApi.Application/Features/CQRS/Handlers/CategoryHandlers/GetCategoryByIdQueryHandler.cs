using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.CQRS.Queries.CategoryQueries;
using MovieApi.Application.Features.CQRS.Results.CategoryResults;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly MovieContext _context;

        public GetCategoryByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<GetCategoryByIdResult> Handle(GetCategoryByIdQuery query)
        {
            var values = await _context.Categories.FindAsync(query.CategoryId);
            return new GetCategoryByIdResult { CategoryName = values.CategoryName };
        }
    }
}
