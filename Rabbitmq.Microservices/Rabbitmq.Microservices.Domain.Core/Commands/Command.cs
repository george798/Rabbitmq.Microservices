using Rabbitmq.Microservices.Domain.Core.Events;

namespace Rabbitmq.Microservices.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
