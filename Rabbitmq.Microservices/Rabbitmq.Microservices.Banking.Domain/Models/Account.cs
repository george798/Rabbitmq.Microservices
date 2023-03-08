namespace Rabbitmq.Microservices.Banking.Domain.Models
{
    public class Account
    {
        public string Id { get; set; }
        public string AccountType { get; set; }
        public string AccountBalance { get; set; }
    }
}
