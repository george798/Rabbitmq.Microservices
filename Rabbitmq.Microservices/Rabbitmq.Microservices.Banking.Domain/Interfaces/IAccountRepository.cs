using Rabbitmq.Microservices.Banking.Domain.Models;

namespace Rabbitmq.Microservices.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        Task<IEnumerable<Account>> GetAllAsync();
    }
}
