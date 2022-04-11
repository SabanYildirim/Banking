using System;

namespace Banking.Application.DTO
{
    public class TransactionLogServiceModel
    {
        public int transactionId { get; set; }
        public int customerId { get; set; }
        public decimal balance { get; set; }
        public int accountId { get; set; }
        public DateTime createdDate { get; set; } = DateTime.Now;
    }
}
