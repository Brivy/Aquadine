using MediatR;

namespace Aquadine.Application.Core.Events
{
    internal class IntegrationEventNotification<TEvent> : INotification
    {
        public IntegrationEventNotification(TEvent @event)
        {
            Event = @event;
        }

        public TEvent Event { get; }
    }
}
