﻿using MovieApi.Application.Features.CQRS.Commands.CategoryCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public RemoveCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Hanlde(RemoveCategoryCommand command)
        {
            var value=await _context.Categories.FindAsync(command.CategoryId);
            _context.Categories.Remove(value);
            await _context.SaveChangesAsync();

        }
    }
}
