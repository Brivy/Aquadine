using Aquadine.Application.Abstractions.Mediator;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Aquadine.Application.Core.Services.Mediator
{
    public class QueryService : IQuerySender
    {
        private readonly IMediator _mediator;

        public QueryService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<TResponse> SendQueryAsync<TResponse>(IRequest<TResponse> query, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(query, cancellationToken);
            return response;
        }
    }
}
