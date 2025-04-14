using MediatR;
using MovieApi.Application.Features.Mediator.Commands.TagCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.Mediator.Handlers.TagHandlers
{
    public class UpdateTagCommandhandler : IRequestHandler<UpdateTagCommand>
    {
        private readonly MovieContext _context;

        public UpdateTagCommandhandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Tags.FindAsync(request.TagId);
            value.Title = request.Title;
            await _context.SaveChangesAsync();
        }
    }
}
