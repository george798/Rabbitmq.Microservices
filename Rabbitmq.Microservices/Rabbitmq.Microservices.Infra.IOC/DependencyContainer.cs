using Microsoft.Extensions.DependencyInjection;
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
        }
    }
}
