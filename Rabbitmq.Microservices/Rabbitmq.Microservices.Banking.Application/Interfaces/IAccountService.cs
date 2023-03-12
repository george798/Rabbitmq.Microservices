using Rabbitmq.Microservices.Banking.Domain.Models;

namespace Rabbitmq.Microservices.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAccountsAsync();
        Task TransferAsync(AccountTransfer accountTransfer);
    }
}
