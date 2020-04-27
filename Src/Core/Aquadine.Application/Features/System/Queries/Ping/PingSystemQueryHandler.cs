using Aquadine.Application.Abstractions.Dtos.System;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Aquadine.Application.Features.System.Queries.Ping
{
    internal class PingSystemQueryHandler : IRequestHandler<PingSystemQuery, PingSystemDto>
    {
        public Task<PingSystemDto> Handle(PingSystemQuery request, CancellationToken cancellationToken)
        {
            var result = new PingSystemDto { Message = "Pong" };

            return Task.FromResult(result);
        }
    }
}
