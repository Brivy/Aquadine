using MediatR;

namespace Aquadine.Application.Core.Events
{
    public class DomainEventNotification<TEvent> : INotification
    {
        public DomainEventNotification(TEvent @event)
        {
            Event = @event;
        }

        public TEvent Event { get; }
    }
}
