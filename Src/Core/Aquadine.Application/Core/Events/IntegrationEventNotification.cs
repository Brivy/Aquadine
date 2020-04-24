using MediatR;

namespace Aquadine.Application.Core.Events
{
    class IntegrationEventNotification<TEvent> : INotification
    {
        public IntegrationEventNotification(TEvent @event)
        {
            Event = @event;
        }

        public TEvent Event { get; }
    }
}
