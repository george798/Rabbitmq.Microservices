using Rabbitmq.Microservices.Domain.Core.Commands;

namespace Rabbitmq.Microservices.Banking.Domain.Commands
{
    public class TransferCommand : Command
    {
        public int From { get; set; }
        public int To { get; set; }
        public decimal Amount { get; set; }
    }
}
