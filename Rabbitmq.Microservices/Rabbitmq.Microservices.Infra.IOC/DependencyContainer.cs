using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rabbitmq.Microservices.Banking.Application.Interfaces;
using Rabbitmq.Microservices.Banking.Application.Services;
using Rabbitmq.Microservices.Banking.Data.Options;
using Rabbitmq.Microservices.Banking.Data.Repository;
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

            //Data layer      
            services.AddTransient<IAccountRepository, AccountRepository>();
        }
    }
}
