using MediatR;
using Rabbitmq.Microservices.Banking.Domain.Commands;
using Rabbitmq.Microservices.Banking.Domain.Events;
using Rabbitmq.Microservices.Domain.Core.Bus;

namespace Rabbitmq.Microservices.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;
        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus; 
        }

        public Task<bool> Handle(CreateTransferCommand command, CancellationToken cancellationToken)
        {
            _bus.Publish(new TransferCreatedEvent(command.From, command.To, command.Amount));
            throw new NotImplementedException();
        }
    }
}
