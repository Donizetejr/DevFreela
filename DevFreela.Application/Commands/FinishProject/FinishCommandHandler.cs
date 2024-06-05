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
    public class FinishCommandHandler : IRequestHandler<DeleteCommand, Unit>
    {
        private readonly DevFreelaDbContext _dbContext;
        private readonly string _connectionString;
        public FinishCommandHandler(DevFreelaDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("DevFreelaCs");
        }
        public async Task<Unit> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == request.Id);

            project.Finish();

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
