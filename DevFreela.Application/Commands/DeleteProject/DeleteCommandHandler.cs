using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.Start
{
    public class DeleteCommandHandler : IRequestHandler<DeleteCommand, Unit>
    {
        private readonly DevFreelaDbContext _dbContext;
        public DeleteCommandHandler(DevFreelaDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
        }
        public async Task<Unit> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == request.Id);

            project.Cancel();

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
