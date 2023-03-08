using Rabbitmq.Microservices.Banking.Application.Interfaces;
using Rabbitmq.Microservices.Banking.Domain.Interfaces;
using Rabbitmq.Microservices.Banking.Domain.Models;

namespace Rabbitmq.Microservices.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<IEnumerable<Account>> GetAccounts()
        {
            return await _accountRepository.GetAllAsync();
        }
    }
}
