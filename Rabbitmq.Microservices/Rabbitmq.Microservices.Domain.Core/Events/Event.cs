namespace Rabbitmq.Microservices.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime Timestamp { get; protected set; }

        protected Event() 
        {
            Timestamp = DateTime.Now;
        }
    }
}
