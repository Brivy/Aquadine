using Aquadine.Application.Abstractions.Mediator;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Aquadine.Application.Core.Services
{
    public class MediatorService : IMediatorService
    {
        private readonly IMediator _mediator;

        public MediatorService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task SendRequestAsync(IRequest command, CancellationToken cancellationToken)
        {
            await _mediator.Send(command, cancellationToken);
        }

        public async Task<TResponse> SendRequestAsync<TResponse>(IRequest<TResponse> command, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(command, cancellationToken);
            return response;
        }

        public async Task<TResponse> SendQueryAsync<TResponse>(IRequest<TResponse> query, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(query, cancellationToken);
            return response;
        }

        public async Task PublishDomainEvent<TDomainEvent>(TDomainEvent domainEvent, CancellationToken cancellationToken)
        {
            await _mediator.Publish(domainEvent);
        }

        public async Task PublishIntegrationEvent<TIntegrationEvent>(TIntegrationEvent integrationEvent, CancellationToken cancellationToken)
        {
            await _mediator.Publish(integrationEvent);
        }
    }
}
