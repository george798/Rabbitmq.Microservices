using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Rabbitmq.Microservices.Banking.Data.Options;
using Rabbitmq.Microservices.Banking.Domain.Interfaces;
using Rabbitmq.Microservices.Banking.Domain.Models;

namespace Rabbitmq.Microservices.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IMongoCollection<Account> _accountCollection;

        public AccountRepository(
            IOptions<MongoOptions> settings)
        {
            var mongoClient = new MongoClient(
                settings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
            settings.Value.DatabaseName);

            _accountCollection = mongoDatabase.GetCollection<Account>(
                settings.Value.CollectionName);
        }

        public async Task<IEnumerable<Account>> GetAllAsync() =>
            await _accountCollection.Find(_ => true).ToListAsync();

        public async Task<Account?> GetAsync(string id) =>
        await _accountCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Account newAccount) =>
        await _accountCollection.InsertOneAsync(newAccount);

        public async Task UpdateAsync(string id, Account updatedAccount) =>
            await _accountCollection.ReplaceOneAsync(x => x.Id == id, updatedAccount);

        public async Task RemoveAsync(string id) =>
            await _accountCollection.DeleteOneAsync(x => x.Id == id);
    }
}
