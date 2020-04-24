using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Aquadine.Application.Core.Services.Mediator
{
    internal class EventService
    {
        private readonly IMediator _mediator;

        public EventService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task PublishDomainEvent<TDomainEvent>(TDomainEvent domainEvent, CancellationToken cancellationToken)
        {
            await _mediator.Publish(domainEvent, cancellationToken);
        }

        public async Task PublishIntegrationEvent<TIntegrationEvent>(TIntegrationEvent integrationEvent, CancellationToken cancellationToken)
        {
            await _mediator.Publish(integrationEvent, cancellationToken);
        }
    }
}
