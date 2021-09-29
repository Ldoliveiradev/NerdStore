using MediatR;
using System;

namespace NerdStore.Core.Messages.CommonMesssages.DomainEvents
{
    public class DomainEvent : Message, INotification
    {
        public DateTime Timestamp { get; private set; }

        public DomainEvent(Guid aggregateId)
        {
            AggregateId = aggregateId;
            Timestamp = DateTime.Now;
        }
    }
}
