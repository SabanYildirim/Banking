using Banking.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Infrastructure.Interfaces
{
    public interface IAccountRepository : IDataRepository<AccountEntity>
    {
        void UpdateBalance (int accountId,decimal money);
        decimal GetBalanceByAccountId(int accountId);
        bool HasAccount(int accountId);
        IEnumerable<AccountEntity> GetAllAccountsByCustomerId(int customerId);
        AccountEntity GetAccountDetail(int accountId);
    }
}
