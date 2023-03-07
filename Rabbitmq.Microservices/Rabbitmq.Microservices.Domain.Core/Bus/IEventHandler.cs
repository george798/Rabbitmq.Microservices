using Rabbitmq.Microservices.Domain.Core.Events;
using System;

namespace Rabbitmq.Microservices.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler where TEvent : Event
    {
        Task Handle(TEvent @event);
    }
    public interface IEventHandler
    {
        
    }

}
