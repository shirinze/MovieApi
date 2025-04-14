﻿using MediatR;
using MovieApi.Application.Features.Mediator.Commands.CastCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.Mediator.Handlers.CastHandlers
{
    public class UpdateCastCommandHandler : IRequestHandler<UpdateCastCommand>
    {
        private readonly MovieContext _context;

        public UpdateCastCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Casts.FindAsync(request.CastId);
            value.Surename=request.Surename;
            value.Overview=request.Overview;
            value.ImageUrl=request.ImageUrl;
            value.Biography = request.Biography;
            value.Title = request.Title;
            value.Name=request.Name;
            await _context.SaveChangesAsync();
        }
    }
}
