﻿using System.Threading;
using System.Threading.Tasks;

namespace Aquadine.Application.Core.Interfaces.Mediator
{
    public interface IEventPublisher
    {
        Task PublishDomainEvent<TDomainEvent>(TDomainEvent domainEvent, CancellationToken cancellationToken);

        Task PublishIntegrationEvent<TIntegrationEvent>(TIntegrationEvent integrationEvent, CancellationToken cancellationToken);
    }
}
