using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Infrastructure.Entities
{
    [Table("Account")]
    public class AccountEntity : BaseEntity
    {
        public int customerId { get; set; }
        public int accountNo { get; set; }
        public string accountName { get; set; }
        public string branch { get; set; }
        public decimal balance { get; set; }
    }
}
