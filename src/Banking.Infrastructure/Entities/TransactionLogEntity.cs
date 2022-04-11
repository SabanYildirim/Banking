using System.ComponentModel.DataAnnotations.Schema;

namespace Banking.Infrastructure.Entities
{
    [Table("TransactionLog")]
    public class TransactionLogEntity : BaseEntity
    {
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public int Balance { get; set; }
    }
}
