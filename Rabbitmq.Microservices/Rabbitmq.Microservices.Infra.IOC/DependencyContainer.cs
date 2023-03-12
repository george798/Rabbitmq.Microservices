using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Rabbitmq.Microservices.Banking.Application.Interfaces;
using Rabbitmq.Microservices.Banking.Application.Services;
using Rabbitmq.Microservices.Banking.Data.Repository;
using Rabbitmq.Microservices.Banking.Domain.CommandHandlers;
using Rabbitmq.Microservices.Banking.Domain.Commands;
using Rabbitmq.Microservices.Banking.Domain.Interfaces;
using Rabbitmq.Microservices.Domain.Core.Bus;
using Rabbitmq.Microservices.Infra.Bus;

namespace Rabbitmq.Microservices.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {

            //Domain bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Application layer
            services.AddTransient<IAccountService, AccountService>();

            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            //Data layer      
            services.AddTransient<IAccountRepository, AccountRepository>();
        }
    }
}
