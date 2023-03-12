namespace Rabbitmq.Microservices.Banking.Domain.Models
{
    public class AccountTransfer
    {
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAccount { get; set; }
    }
}
