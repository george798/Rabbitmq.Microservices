using Rabbitmq.Microservices.Domain.Core.Events;

namespace Rabbitmq.Microservices.Banking.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public int From { get; private set; }
        public int To { get; private set; }
        public decimal Account { get; set; }
        public TransferCreatedEvent(int from, int to, decimal account)
        {
            From = from;
            To = to;
            Account = account;
        }
    }
}
