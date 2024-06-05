using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.CreateComment
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, Unit>
    {
        private readonly DevFreelaDbContext _dbContext;
        public CreateCommentCommandHandler(DevFreelaDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
        }
        public async Task<Unit> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var comment = new ProjectComment(request.Content, request.IdProject, request.IdUser);

            await _dbContext.ProjectComments.AddAsync(comment);

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
