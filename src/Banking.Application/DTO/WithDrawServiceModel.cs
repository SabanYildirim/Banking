using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.DTO
{
    public class WithDrawServiceModel
    {
        public int customerId { get; set; }
        public int accountId { get; set; }
        public decimal money { get; set; }
    }
}
