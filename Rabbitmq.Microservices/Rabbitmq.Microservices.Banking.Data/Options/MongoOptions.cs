namespace Rabbitmq.Microservices.Banking.Data.Options
{
    public class MongoOptions
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string CollectionName { get; set; } = null!;
    }
}
