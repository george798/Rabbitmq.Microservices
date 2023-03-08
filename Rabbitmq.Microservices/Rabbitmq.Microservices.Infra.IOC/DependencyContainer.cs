using Microsoft.Extensions.DependencyInjection;
using Rabbitmq.Microservices.Domain.Core.Bus;
using Rabbitmq.Microservices.Infra.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
