using Rabbitmq.Microservices.Banking.Application.Interfaces;
using Rabbitmq.Microservices.Banking.Domain.Commands;
using Rabbitmq.Microservices.Banking.Domain.Interfaces;
using Rabbitmq.Microservices.Banking.Domain.Models;
using Rabbitmq.Microservices.Domain.Core.Bus;

namespace Rabbitmq.Microservices.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _eventBus;


        public AccountService(IAccountRepository accountRepository, IEventBus eventBus)
        {
            _accountRepository = accountRepository;
            _eventBus = eventBus;   
        }

        public async Task<IEnumerable<Account>> GetAccountsAsync()
        {
            return await _accountRepository.GetAllAsync();
        }

        public async Task TransferAsync(AccountTransfer accountTransfer)
        {
            var command = new CreateTransferCommand(accountTransfer.FromAccount,
                                                 accountTransfer.ToAccount,
                                                 accountTransfer.TransferAccount);

            await _eventBus.SendCommand(command);
        }
    }
}
