using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.DTO
{
    public class AccountServiceModel
    {
        public int customerId { get; set; }
        public int accountNo { get; set; }
        public string accountName { get; set; }
        public string accountBranch { get; set; }
        public decimal balance { get; set; }
    }
}
